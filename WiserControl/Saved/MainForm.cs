using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wiser.DataObjects;

namespace WiserControl
{
    public partial class MainForm : Form
    {
        private HeatHub _hub;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void RefreshPanel()
        {
            timeLabel.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm");

            _hub = Program.wiserConnection.GetData();
            foreach (var room in _hub.Room)
            {
                var control = GetRoomControl(room.Name);
                if (control == null)
                {
                    var newControl = new WiserRoomControl(room);
                    newControl.ChangeRequested += NewControl_ChangeRequested;
                    controlPanel.Controls.Add(newControl);
                }
                else
                {
                    control.Refresh(room);
                }
            }

            var waterControl = GetHotWaterControl();
            if (waterControl == null)
            {
                var newControl = new WiserWaterControl(_hub.HotWater[0]);
                newControl.ChangeRequested += NewControl_ChangeRequested;
                leftPanel.Controls.Add(newControl);
            }
            else
                waterControl.Refresh(_hub.HotWater[0]);
        }

        private void NewControl_ChangeRequested(object sender, EventArgs e)
        {
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
            this.Size = Settings.Default.WindowSize;
            this.Location = Settings.Default.WindowLocation;
            this.WindowState = Settings.Default.WindowsState;
            this.WindowState = FormWindowState.Maximized;

            controlPanel.Visible = false;
            controlPanel.SuspendLayout();

            RefreshPanel();

            if (Settings.Default.ControlTiles != null)
                for (int i = 0; i < Settings.Default.ControlTiles.Count; i++)
                    controlPanel.Controls.SetChildIndex(GetRoomControl(Settings.Default.ControlTiles[i]), i);

            controlPanel.ResumeLayout();
            controlPanel.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
            //Settings.Default.ControlTiles = null;

            // Copy window size to app settings
            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.WindowSize = this.Size;
            }
            else
            {
                Settings.Default.WindowSize = this.RestoreBounds.Size;
            }

            // Save settings
            Settings.Default.Save();
        }
    }
}
