using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wiser.DataObjects;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WiserControl
{
    public partial class WiserRoomControl : UserControl
    {
        public event EventHandler ChangeRequested;

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }
        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
        private void RecreateRegion()
        {
            var bounds = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
            bounds.Inflate(-1, -1);
            using (var path = GetRoundRectagle(bounds, this.Radius))
                this.Region = new Region(path);
            this.Invalidate();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }


        protected void RoundControl(Control control)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, control.Width, control.Height);
            control.Region = new Region(path);
        }

        public Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics graphics__1 = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics__1.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics__1.Dispose();
            return bmp;
        }



        private Room _room;
        public string RoomName { get { return _room.Name; } }

        public WiserRoomControl(string roomName)
        {
            _room = new Room();
            _room.Name = roomName;
        }

        public WiserRoomControl(Room room)
        {
            InitializeComponent();
            //rounded corners!
            this.RecreateRegion();

            //round up the boost labels
            foreach (Control label in boostPanel.Controls)
                RoundControl(label);

            foreach (Control c in bottomPanel.Controls)
                c.Top = bottomPanel.Height / 2 - c.Height / 2;
            foreach (Control c in buttonPanel.Controls)
                c.Top = buttonPanel.Height / 2 - c.Height / 2;

            //circular region for the setpoint
            //var path = new System.Drawing.Drawing2D.GraphicsPath();
            //var boundsRect = new Rectangle(0, 0, setPointLabel.Width, setPointLabel.Height);
            //path.AddEllipse(boundsRect);
            //this.setPointLabel.Region = new Region(path);

            Refresh(room);
        }

        public override string ToString()
        {
            return _room.Name;
        }
        /// <summary>
        /// Displays the current set point and changes colour of bottom panel 
        /// </summary>
        /// <param name="setPoint"></param>
        private void DisplaySetPoint(int setPoint)
        {
            setPointLabel.Text = string.Format("{0:0}°C", (double)setPoint / 10);
            if ((double)setPoint / 10 == -20)
                setPointLabel.Text = "Off";

            SetColour(bottomPanel, _room.DisplayedSetPoint);
        }

        public void Refresh(Room room)
        {
            _room = room;
            roomLabel.Text = _room.Name;
            currrentTempLabel.Text = string.Format("{0:0.0}°C", (double)room.RoundedAlexaTemperature / 10);
            DisplaySetPoint(room.DisplayedSetPoint);

            autoManualPictureBox.Tag = _room.SetPointOrigin; // == "FromSchedule" ? "auto": "manual" ;   //FromManualOverride
            ShowAutoManualImage();
            ShowBatteryStatus();

            if (room.PercentageDemand > 0)
            {
                heatDemandPictureBox.Visible = true;
                heatDemandPictureBox.Image = ChangeOpacity(Resources.HeatDemandImage, (float)room.PercentageDemand / 100);
            }
            else
                heatDemandPictureBox.Visible = false;

        }

        private enum BatteryStatus
        {
            Critical,
            Low,
            OneThird,
            Normal
        }

        private void ShowBatteryStatus()
        {
            var worstStatus = BatteryStatus.Normal;

            foreach (int id in _room.SmartValveIds)
            {
                var device = Program.MainForm.GetDeviceById(id);
                if (device != null)
                {
                    BatteryStatus status;
                    if (Enum.TryParse(device.BatteryLevel, out status))
                        if (status < worstStatus)
                            worstStatus = status;
                }
            }

            if (_room.RoomStatId > 0)
            { 
                var device = Program.MainForm.GetDeviceById(_room.RoomStatId);
                if (device != null)
                {
                    BatteryStatus status;
                    if (Enum.TryParse(device.BatteryLevel, out status))
                        if (status < worstStatus)
                            worstStatus = status;
                }
            }

            switch (worstStatus)
            {
                case BatteryStatus.Critical:
                    batteryPictureBox.Image = Resources.BatteryCriticalImage;
                    FlashBatteryIcon(true);
                    break;
                case BatteryStatus.Low:
                    batteryPictureBox.Image = Resources.BatteryOneThirdImage;
                    FlashBatteryIcon(false);
                    break;
                case BatteryStatus.OneThird:
                    batteryPictureBox.Image = Resources.BatteryTwoThirdsImage;
                    FlashBatteryIcon(false);
                    break;
                default:
                    batteryPictureBox.Image = Resources.BatteryNormalImage;
                    FlashBatteryIcon(false);
                    break;
            }
        }

        private void FlashBatteryIcon(bool flash)
        {
            if (flash)
            {
                if (!timer1.Enabled)
                    timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                batteryPictureBox.Visible = true;
            }
        }

        private void SetColour(Control control, int temperature)
        {
            if (temperature < 180)
                control.BackColor = Color.LightBlue;
            else if (temperature < 190)
                control.BackColor = Color.Azure;
            else if (temperature < 200)
                control.BackColor = Color.Linen;
            else if (temperature < 210)
                control.BackColor = Color.Bisque;
            else if (temperature < 220)
                control.BackColor = Color.Gold;
            else if (temperature < 230)
                control.BackColor = Color.MistyRose;
            else
                control.BackColor = Color.LightCoral;
        }

        private void WiserRoomControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.All);
        }

        private void WiserRoomControl_Paint(object sender, PaintEventArgs e)
        {
            //roomLabel.BackColor = BackColor;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            Program.wiserConnection.SetRoomOverride(_room.id, _room.DisplayedSetPoint += 10);
            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void currrentTempLabel_Layout(object sender, LayoutEventArgs e)
        {
            currrentTempLabel.Left = mainPanel.Width / 2 - currrentTempLabel.Width / 2;
            currrentTempLabel.Top = mainPanel.Height / 2 - currrentTempLabel.Height / 2;
        }

        private void upPictureBox_Click(object sender, EventArgs e)
        {
            Program.wiserConnection.SetRoomOverride(_room.id, _room.DisplayedSetPoint += 10);
            DisplaySetPoint(_room.DisplayedSetPoint);

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void downPictureBox_Click(object sender, EventArgs e)
        {
            Program.wiserConnection.SetRoomOverride(_room.id, _room.DisplayedSetPoint -= 10);
            DisplaySetPoint(_room.DisplayedSetPoint);

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void noOverridePictureBox_Click(object sender, EventArgs e)
        {
        }

        private void manualOverridePictureBox_Click(object sender, EventArgs e)
        {
        }

        private void ShowAutoManualImage()
        {
            switch (autoManualPictureBox.Tag.ToString())
            {
                case "FromSchedule":
                    autoManualPictureBox.Image = Resources.ScheduleImage;
                    break;
                case "FromManualOverride":
                    autoManualPictureBox.Image = Resources.ManualImage;
                    break;
                case "FromComfortMode":
                    autoManualPictureBox.Image = Resources.ComfortOnImage;
                    break;
                case "FromEco":
                    autoManualPictureBox.Image = Resources.EcoOnImage;
                    break;
                case "FromBoost":
                    autoManualPictureBox.Image = Resources.BoostImage;
                    break;
                default:
                    autoManualPictureBox.Image = Resources.ScheduleImage;
                    break;

            }
        }

        private void autoManualPictureBox_Click(object sender, EventArgs e)
        {
            boostPanel.Visible = false;
            if (autoManualPictureBox.Tag.ToString() == "FromSchedule")
            {
                autoManualPictureBox.Tag = "FromManualOverride";
            }
            else if (autoManualPictureBox.Tag.ToString() == "FromManualOverride" || autoManualPictureBox.Tag.ToString() == "FromBoost")
            {
                Program.wiserConnection.DisableRoomOverride(_room.id);
                if (ChangeRequested != null)
                    ChangeRequested(this, null);

                autoManualPictureBox.Tag = "FromSchedule";
            }
            ShowAutoManualImage();
        }

        private void roomLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.All);
        }

        private void boostPictureBox_Click(object sender, EventArgs e)
        {
            boostPanel.BringToFront();
            boostPanel.Visible = !boostPanel.Visible;
        }

        private void boostLabel_Click(object sender, EventArgs e)
        {
            boostPanel.Visible = false;
            int duration = Int32.Parse(((Control)sender).Tag.ToString());
            Program.wiserConnection.SetRoomOverride(_room.id, _room.RoundedAlexaTemperature + 20, duration);

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            batteryPictureBox.Visible = !batteryPictureBox.Visible;
        }

        private void graphPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void setPointLabel_Click(object sender, EventArgs e)
        {
            var graphForm = new RoomHistoryForm(_room.Name);
            graphForm.ShowDialog();

        }
    }
}
