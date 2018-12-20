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

namespace WiserControl.Hidden
{
    public partial class WiserRoomControl : UserControl
    {
        public event EventHandler ChangeRequested;

        private int radius = 30;
        [DefaultValue(30)]
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

            //circular region for the setpoint
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            var boundsRect = new Rectangle(0, 0, setPointLabel.Width, setPointLabel.Height);
            path.AddEllipse(boundsRect);
            this.setPointLabel.Region = new Region(path);



            Refresh(room);
        }

        public void Refresh(Room room)
        {
            _room = room;
            roomLabel.Text = _room.Name;
            currrentTempLabel.Text = string.Format("{0:0.0}°C", (double)room.RoundedAlexaTemperature / 10);
            setPointLabel.Text = string.Format("{0:0}°C", (double)room.DisplayedSetPoint / 10);
            if ((double)room.DisplayedSetPoint / 10 == -20)
                setPointLabel.Text = "Off";

            autoManualPictureBox.Tag = _room.SetPointOrigin; // == "FromSchedule" ? "auto": "manual" ;   //FromManualOverride
            ShowAutoManualImage();
            heatDemandPictureBox.Visible = room.PercentageDemand > 0;

            SetColour(setPointLabel, _room.DisplayedSetPoint);
            SetColour(this, _room.RoundedAlexaTemperature);
            var boundsRect = new Rectangle(setPointLabel.Left - setPointLabel.Width / 4, setPointLabel.Parent.Top + setPointLabel.Top - setPointLabel.Height / 4, (int)(setPointLabel.Width * 1.5), (int)(setPointLabel.Height * 1.5));
            //boundsRect.Inflate(-20, -20);
            this.CreateGraphics().DrawEllipse(new Pen(Color.Orange, 3), boundsRect);
        }

        private void SetColour(Control control, int temperature)
        {
            if (temperature < 180)
                control.BackColor = Color.LightBlue;
            else if (temperature < 190)
                control.BackColor = Color.Azure;
            else if (temperature < 200)
                control.BackColor = Color.Bisque;
            else if (temperature < 210)
                control.BackColor = Color.MistyRose;
            else if (temperature < 220)
                control.BackColor = Color.LightCoral;
            else
                control.BackColor = Color.IndianRed;
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
            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void downPictureBox_Click(object sender, EventArgs e)
        {
            Program.wiserConnection.SetRoomOverride(_room.id, _room.DisplayedSetPoint -= 10);
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
                    autoManualPictureBox.Image = imageList1.Images[1];
                    break;
                case "FromManualOverride":
                    autoManualPictureBox.Image = imageList1.Images[0];
                    break;
                case "FromComfortMode":
                    break;
                default:
                    autoManualPictureBox.Image = imageList1.Images[1];
                    break;

            }
        }

        private void autoManualPictureBox_Click(object sender, EventArgs e)
        {
            if (autoManualPictureBox.Tag.ToString() == "FromSchedule")
            {
                autoManualPictureBox.Tag = "FromManualOverride";
            }
            else if (autoManualPictureBox.Tag.ToString() == "FromManualOverride")
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
    }
}
