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
    public partial class WiserSystemControl : UserControl
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

        private HeatHub _hub;
        private Wiser.DataObjects.System _system;

        public WiserSystemControl(HeatHub hub)
        {
            InitializeComponent();
            this.RecreateRegion();

            Refresh(hub);
        }

        public void Refresh(HeatHub hub)
        {
            _hub = hub;
            _system = hub.System;
            ecoPictureBox.Tag = _system.EcoModeEnabled;
            comfortPictureBox.Tag = _system.ComfortModeEnabled;
            awayPictureBox.Tag = _system.OverrideType == null || _system.OverrideType != "Away" ? false : true;

            heatingRelayPictureBox.Tag = hub.HeatingChannel[0].HeatingRelayState == "On";
            hotWaterRelayPictureBox.Tag = hub.HotWater[0].HotWaterRelayState == "On";

            ShowImages();
            //            autoManualPictureBox.Tag = _system..HotWaterDescription; // == "FromSchedule" ? "auto": "manual" ;   //FromManualOverride
            //            ShowAutoManualImage();
        }

        private void WiserRoomControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.All);
        }

        private void WiserRoomControl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ShowImages()
        {
            ecoPictureBox.Image = (bool)ecoPictureBox.Tag ? Resources.EcoOnImage : Resources.EcoOffImage;
            comfortPictureBox.Image = (bool)comfortPictureBox.Tag ? Resources.ComfortOnImage : Resources.ComfortOffImage;
            awayPictureBox.Image = (bool)awayPictureBox.Tag ? Resources.AwayOnImage : Resources.AwayOffImage;
            hotWaterRelayPictureBox.Image = (bool)hotWaterRelayPictureBox.Tag ? Resources.HotWaterOnImage : Resources.HotWaterOffImage;
            heatingRelayPictureBox.Image = (bool)heatingRelayPictureBox.Tag ? Resources.HeatingOnImage : Resources.HeatingOffImage;

        }



        private void WiserWaterControl_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_DoubleClick(object sender, EventArgs e)
        {
            Program.MainForm.ToggleMaximised();
        }

        private void awayPictureBox_Click(object sender, EventArgs e)
        {
            var newState = !((bool)awayPictureBox.Tag);
            Program.wiserConnection.EnableAwayMode(newState);
            awayPictureBox.Tag = newState;

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void ecoPictureBox_Click(object sender, EventArgs e)
        {
            var newState = !((bool)ecoPictureBox.Tag);
            Program.wiserConnection.EnableEcoMode(newState);
            ecoPictureBox.Tag = newState;

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void comfortPictureBox_Click(object sender, EventArgs e)
        {
            var newState = !((bool)comfortPictureBox.Tag);
            Program.wiserConnection.EnableComfortMode(newState);
            comfortPictureBox.Tag = newState;

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void resetToSchedulePictureBox_Click(object sender, EventArgs e)
        {
            Program.wiserConnection.RemoveAllOverrides();

            if (ChangeRequested != null)
                ChangeRequested(this, null);
        }

        private void heatingRelayPictureBox_DoubleClick(object sender, EventArgs e)
        {
            //'Kludge' - used to export valve data
        }
    }
}
