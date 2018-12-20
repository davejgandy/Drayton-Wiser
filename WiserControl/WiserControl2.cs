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

namespace WiserControl
{
    public partial class WiserControl : UserControl
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

        public WiserControl()
        {
            InitializeComponent();
            //rounded corners!
            this.RecreateRegion();

            foreach (Control c in bottomPanel.Controls)
                c.Top = bottomPanel.Height / 2 - c.Height / 2;
        }

        protected void SetColour(Control control, int temperature)
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

        protected void WiserRoomControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.All);
        }

        protected void roomLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.All);
        }


        protected void ShowAutoManualImage()
        {
            switch (statusPictureBox.Tag.ToString())
            {
                case "FromSchedule":
                    statusPictureBox.Image = Resources.ScheduleImage;
                    break;
                case "FromManualOverride":
                    statusPictureBox.Image = Resources.ManualImage;
                    break;
                case "FromComfortMode":
                    statusPictureBox.Image = Resources.ComfortImage;
                    break;
                case "FromEco":
                    statusPictureBox.Image = Resources.EcoImage;
                    break;
                case "FromBoost":
                    statusPictureBox.Image = Resources.BoostImage;
                    break;
                default:
                    statusPictureBox.Image = Resources.ScheduleImage;
                    break;
            }
        }
    }
}
