using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wiser;
using Wiser.DataObjects;

namespace WiserSystemTrayApp
{
    public partial class mainForm : Form
    {
        private HeatHub _hub;
        private WiserConnection _connection;
        public mainForm()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.notifyIcon1.Text = this.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connection = new WiserConnection();
            notifyIcon1.ShowBalloonTip(500, this.Text, "Connected to Heat Hub", ToolTipIcon.Info);

        }

        private void mainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            _hub = _connection.GetData();
            mainContextMenuStrip.Items.Clear();

            foreach (var r in _hub.Room.OrderBy(r => r.Name))
            {
                var newMenu = mainContextMenuStrip.Items.Add(r.Name) as ToolStripMenuItem;
                newMenu.Image = GetTempImage((double)r.RoundedAlexaTemperature);
                //newMenu.ForeColor = GetInterpolatedColor(Color.DarkBlue, Color.Red, r.PercentageDemand / 100);
                newMenu.ForeColor = GetColorForHeatDemand(r.PercentageDemand);

                ToolStripLabel dropDownLabel = new ToolStripLabel("(Set by " + r.SetPointOrigin.Substring(4) + ")");
                dropDownLabel.Image = GetTempImage((double)r.DisplayedSetPoint);
                int i = newMenu.DropDownItems.Add(dropDownLabel);
                newMenu.DropDownItems.Add("-");

                //find boost end datetime
                int boostMinutes = 0;
                if (r.OverrideTimeoutUnixTime != 0)
                {
                    var boostEnd = GetDateFromUnixTime(r.OverrideTimeoutUnixTime);
                    boostMinutes = (int)(boostEnd - DateTime.Now).TotalMinutes;
                }

                var newDropDownItem = newMenu.DropDownItems.Add("Off", null, BoostOff_Click) as ToolStripMenuItem;
                newDropDownItem.Tag = r;
                newDropDownItem.Checked = boostMinutes == 0;
                newDropDownItem = newMenu.DropDownItems.Add("30 mins", null, Boost30_Click) as ToolStripMenuItem;
                newDropDownItem.Tag = r;
                newDropDownItem.Checked = (boostMinutes > 0 && boostMinutes <= 30);
                newDropDownItem = newMenu.DropDownItems.Add("1 hour", null, Boost1_Click) as ToolStripMenuItem;
                newDropDownItem.Tag = r;
                newDropDownItem.Checked = (boostMinutes > 30 && boostMinutes <= 60);
                newDropDownItem = newMenu.DropDownItems.Add("2 hours", null, Boost1_Click) as ToolStripMenuItem;
                newDropDownItem.Tag = r;
                newDropDownItem.Checked = (boostMinutes > 60 && boostMinutes <= 120);
                newDropDownItem = newMenu.DropDownItems.Add("3 hours", null, Boost1_Click) as ToolStripMenuItem;
                newDropDownItem.Tag = r;
                newDropDownItem.Checked = (boostMinutes > 120);
            }

            mainContextMenuStrip.Items.Add("-");
            var newWaterMenu = mainContextMenuStrip.Items.Add("Hot Water", null, HotWater_Click) as ToolStripMenuItem;
            newWaterMenu.ForeColor = IsHotWaterOn() ? Color.Red : Color.DarkBlue;
            newWaterMenu.Image = GetWaterStatusImage();
           

            mainContextMenuStrip.Items.Add("-");
            mainContextMenuStrip.Items.Add("E&xit", null, Exit_Click);
            //mainContextMenuStrip.Items.Add("Dump", null, Dump_Click);

        }

        private Color GetColorForHeatDemand(int percentageDemand)
        {
            if (percentageDemand == 0)
                return Color.Black;
            else if (percentageDemand < 25)
                return Color.DarkRed;
            else if (percentageDemand < 50)
                return Color.IndianRed;
            else if (percentageDemand < 75)
                return Color.DarkSalmon;
            else
                return Color.Red;

        }

        private Color GetInterpolatedColor(Color minColor, Color maxColor, float value01)
        {
            float midR = (maxColor.R - minColor.R) * value01 + minColor.R;
            float midG = (maxColor.G - minColor.G) * value01 + minColor.G;
            float midB = (maxColor.B - minColor.B) * value01 + minColor.B;

            Color midColor = Color.FromArgb((int)midR, (int)midR, (int)midB);
            return midColor;
        }

        public DateTime GetDateFromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var timeSpan = TimeSpan.FromSeconds(unixTime);
            return epoch.Add(timeSpan).ToLocalTime();
        }

        private Bitmap GetMenuImage(Color imageColor, string imageText, float fontSize = 25)
        {
            Bitmap bmp = new Bitmap(50, 50);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(imageColor);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Center;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            g.DrawString(imageText, new Font("Small Font", fontSize), Brushes.Black, rect, drawFormat);

            return bmp;
        }

        private bool IsHotWaterOn()
        {
            return _hub.HotWater[0].WaterHeatingState == "On";
        }

        private Bitmap GetWaterStatusImage()
        {
            Bitmap bmp;
            if (IsHotWaterOn())
                bmp = GetMenuImage(Color.LightCoral, "On", 21);
            else
                bmp = GetMenuImage(Color.LightBlue, "Off", 21);

            return bmp;
        }

        private Bitmap GetTempImage(double temperature)
        {
            //int temperature = room.RoundedAlexaTemperature;
            Color imageColor;

            if (temperature < 180)
                imageColor = Color.LightBlue;
            else if (temperature < 190)
                imageColor = Color.Azure;
            else if (temperature < 200)
                imageColor = Color.Linen;
            else if (temperature < 210)
                imageColor = Color.Bisque;
            else if (temperature < 220)
                imageColor = Color.Gold;
            else if (temperature < 230)
                imageColor = Color.MistyRose;
            else
                imageColor = Color.LightCoral;

            Bitmap bmp;
            if (temperature < 0)
                bmp = GetMenuImage(imageColor, "Off", 21);// new Font("Small Font",21), Brushes.Black, rect, drawFormat);
            else
                bmp = GetMenuImage(imageColor, string.Format("{0:0}", temperature / 10)); //, new Font("Small Font", 25), Brushes.Black, rect, drawFormat);

            return bmp;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HotWater_Click(object sender, EventArgs e)
        {
            _connection.SetHotWaterOverride(_hub.HotWater[0].id, !IsHotWaterOn());
        }

        private void Dump_Click(object sender, EventArgs e)
        {
            var data = _connection.GetDataJSON();
            File.WriteAllText(string.Format(@"{0}_{1}.txt", "HubData", DateTime.Now.ToString("yyyyMMddHHmmss")), data);
        }



        private void BoostOff_Click(object sender, EventArgs e)
        {
            var room = ((ToolStripMenuItem)sender).Tag as Room;
            _connection.DisableRoomOverride(room.id);
        }
        private void Boost30_Click(object sender, EventArgs e)
        {
            var room = ((ToolStripMenuItem)sender).Tag as Room;
            _connection.SetRoomOverride(room.id, room.RoundedAlexaTemperature + 20, 30);
        }
        private void Boost1_Click(object sender, EventArgs e)
        {
            var room = ((ToolStripMenuItem)sender).Tag as Room;
            _connection.SetRoomOverride(room.id, room.RoundedAlexaTemperature + 20, 60);
        }
        private void Boost2_Click(object sender, EventArgs e)
        {
            var room = ((ToolStripMenuItem)sender).Tag as Room;
            _connection.SetRoomOverride(room.id, room.RoundedAlexaTemperature + 20, 120);
        }
        private void Boost3_Click(object sender, EventArgs e)
        {
            var room = ((ToolStripMenuItem)sender).Tag as Room;
            _connection.SetRoomOverride(room.id, room.RoundedAlexaTemperature + 20, 180);
        }


    }
}
