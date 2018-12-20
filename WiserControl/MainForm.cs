using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wiser.DataObjects;
using WiserMonitor;

namespace WiserControl
{
    public partial class MainForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private HeatHub _hub;
        private DataLogger _dataLogger;
        private DateTime _lastLogTime;
        public MainForm()
        {
            InitializeComponent();
            _dataLogger = new WiserMonitor.DataLogger();
            statusMessageLabel.BackColor = timeLabel.BackColor;
            statusMessageLabel.ForeColor = timeLabel.ForeColor;
        }

        public DataLogger DataLogger { get { return _dataLogger; } }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void UpdateStatus(string message)
        {
            statusMessageLabel.Text = message;
            statusMessageLabel.Refresh();
        }

        public bool HubWaterBoost { get; protected set; }
        public bool HubHeatingBoost { get; protected set; }
        public Device GetDeviceById(int id)
        {
            foreach (var device in _hub.Device)
            {
                if (device.id == id)
                    return device;
            }
            return null;
        }


        private void RefreshPanel()
        {
            UpdateStatus("Connecting to Hub");
            _hub = Program.wiserConnection.GetData();

            string time = _hub.System.LocalDateAndTime.Time.ToString();
            time = time.PadRight(3, '0');
            time = time.Insert(time.Length - 2, ":");
            timeLabel.Text = string.Format("{0} {1} {2} {3} {4}", _hub.System.LocalDateAndTime.Day, _hub.System.LocalDateAndTime.Date, _hub.System.LocalDateAndTime.Month, _hub.System.LocalDateAndTime.Year, time);

            UpdateStatus("Refreshing");

            HubWaterBoost = _hub.System.HotWaterButtonOverrideState == "On";
            HubHeatingBoost = _hub.System.HeatingButtonOverrideState == "On";

            foreach (var room in _hub.Room)
            {
                var control = GetRoomControl(room.Name);
                if (control == null)
                {
                    log.DebugFormat("Adding Room Control for {0}", room.Name);
                    var newControl = new WiserRoomControl(room);
                    newControl.ChangeRequested += NewControl_ChangeRequested;
                    controlPanel.Controls.Add(newControl);
                }
                else
                {
                    control.Refresh(room);
                }
            }

            var systemControl = GetSystemControl();
            if (systemControl == null)
            {
                log.Debug("Adding System Control");
                var newControl = new WiserSystemControl(_hub);
                newControl.ChangeRequested += NewControl_ChangeRequested;
                leftPanel.Controls.Add(newControl);
            }
            else
                systemControl.Refresh(_hub);


            var waterControl = GetHotWaterControl();
            if (waterControl == null)
            {
                log.Debug("Adding Water Control");
                var newControl = new WiserWaterControl(_hub.HotWater[0]);
                newControl.ChangeRequested += NewControl_ChangeRequested;
                leftPanel.Controls.Add(newControl);
            }
            else
                waterControl.Refresh(_hub.HotWater[0]);

            UpdateStatus(string.Empty);
        }

        private void NewControl_ChangeRequested(object sender, EventArgs e)
        {
            log.DebugFormat("Refresh requested by {0}", sender);
            RefreshPanel();
        }

        private WiserRoomControl GetRoomControl(string name)
        {
            foreach (var control in controlPanel.Controls)
            {
                if (control is WiserRoomControl && ((WiserRoomControl)control).RoomName == name)
                    return (WiserRoomControl)control;
            }
            return null;
        }

        private WiserWaterControl GetHotWaterControl()
        {
            foreach (var control in leftPanel.Controls)
            {
                if (control is WiserWaterControl)
                    return (WiserWaterControl)control;
            }
            return null;
        }

        private WiserSystemControl GetSystemControl()
        {
            foreach (var control in leftPanel.Controls)
            {
                if (control is WiserSystemControl)
                    return (WiserSystemControl)control;
            }
            return null;
        }



        private void controlPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void controlPanel_DragDrop(object sender, DragEventArgs e)
        {
            FlowLayoutPanel _destination = (FlowLayoutPanel)sender;
            var c = e.Data.GetData(typeof(WiserRoomControl)) as Control;
            // Just add the control to the new panel.
            // No need to remove from the other panel,
            // this changes the Control.Parent property.
            Point p = _destination.PointToClient(new Point(e.X, e.Y));
            var item = _destination.GetChildAtPoint(p);
            int index = _destination.Controls.GetChildIndex(item, false);
            _destination.Controls.SetChildIndex(c, index);
            _destination.Invalidate();
        }

        private void controlPanel_DoubleClick(object sender, EventArgs e)
        {
            RefreshPanel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //main presentation bits
            timeLabel.Refresh();
            this.Size = Settings.Default.WindowSize;
            this.Location = Settings.Default.WindowLocation;
            this.WindowState = Settings.Default.WindowsState;
            SetTitleControls();

            _lastLogTime = Settings.Default.LastLogTime;

            //load up all the tile controls
            controlPanel.Visible = false;
            controlPanel.SuspendLayout();

            RefreshPanel();

            //put the tiles in the right display order
            if (Settings.Default.ControlTiles != null)
                for (int i = 0; i < Settings.Default.ControlTiles.Count; i++)
                    controlPanel.Controls.SetChildIndex(GetRoomControl(Settings.Default.ControlTiles[i]), i);

            controlPanel.ResumeLayout();
            controlPanel.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_lastLogTime == DateTime.MinValue || DateTime.Now.Subtract(_lastLogTime).TotalMinutes >= 15)
            {
                log.DebugFormat("Writing Data Log (previous log was {0})", _lastLogTime);
                _dataLogger.WriteValveData(_hub);
                _dataLogger.WriteRoomData(_hub);
                _lastLogTime = DateTime.Now;
            }

            RefreshPanel();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Copy window location to app settings
            Settings.Default.WindowLocation = this.Location;
            Settings.Default.WindowsState = this.WindowState;
            var tileNames = new System.Collections.Specialized.StringCollection();
            foreach (var control in controlPanel.Controls)
            {
                var roomControl = control as WiserRoomControl;
                if (roomControl != null)
                    tileNames.Add(roomControl.RoomName);
            }
            Settings.Default.ControlTiles = tileNames;

            // Copy window size to app settings
            if (this.WindowState == FormWindowState.Normal)
                Settings.Default.WindowSize = this.Size;
            else
                Settings.Default.WindowSize = this.RestoreBounds.Size;

            Settings.Default.LastLogTime = _lastLogTime;

            // Save settings
            Settings.Default.Save();
        }

        internal void ToggleMaximised()
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;

        }
        internal void SetTitleControls()
        {
            this.SuspendLayout();
            this.MaximizeBox = this.ControlBox = this.MinimizeBox = this.ShowInTaskbar = WindowState == FormWindowState.Normal;
            this.Text = this.WindowState == FormWindowState.Normal ? "Wiser Control Panel" : string.Empty;
            this.ResumeLayout();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            SetTitleControls();
        }

        private void timeLabel_DoubleClick(object sender, EventArgs e)
        {
            _dataLogger.ExportCSV();
        }

        private void statusMessageLabel_DoubleClick(object sender, EventArgs e)
        {
            _dataLogger.WriteRoomData(_hub);
        }
    }
}
