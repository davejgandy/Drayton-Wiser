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

namespace Wiser
{
    public partial class WiserWaterControl : UserControl
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

        private HotWater _hotWater;

        public WiserWaterControl(HotWater hotWater)
        {
            InitializeComponent();
            this.RecreateRegion();

            Refresh(hotWater);
        }

        public void Refresh(HotWater hotWater)
        {
            _hotWater = hotWater;
            toggleSwitch1.Checked = hotWater.HotWaterRelayState == "On";
            //manualOverridePictureBox.Visible = hotWater.SetPointOrigin == "FromManualOverride";
            //noOverridePictureBox.Visible = _room.SetPointOrigin == "FromSchedule";

        }

        private void WiserRoomControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.All);
        }

        private void WiserRoomControl_Paint(object sender, PaintEventArgs e)
        {
            //roomLabel.BackColor = BackColor;
        }



        private void noOverridePictureBox_Click(object sender, EventArgs e)
        {
        }

        private void manualOverridePictureBox_Click(object sender, EventArgs e)
        {
            //Program.wiserConnection.DisableRoomOverride(_room.id);
            //if (ChangeRequested != null)
            //    ChangeRequested(this, null);

        }

        private void toggleSwitch1_Layout(object sender, LayoutEventArgs e)
        {
            toggleSwitch1.Left = Width / 2 - toggleSwitch1.Width / 2;
            toggleSwitch1.Top = Height / 2 - toggleSwitch1.Height / 2;
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void toggleSwitch1_Click(object sender, EventArgs e)
        {
            Program.wiserConnection.SetHotWaterOverride(_hotWater.id, !toggleSwitch1.Checked);
            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void WiserWaterControl_Load(object sender, EventArgs e)
        {
            toggleSwitch1.Left = Width / 2 - toggleSwitch1.Width / 2;
            toggleSwitch1.Top = Height / 2 - toggleSwitch1.Height / 2;

        }
    }
}
