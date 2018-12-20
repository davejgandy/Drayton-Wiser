using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WiserMonitor;

namespace WiserControl
{
    public partial class RoomHistoryForm : Form
    {
        class ChartData
        {
            public DateTime DataDate;
            public double Actual;
            public double Set;
        }

        List<RoomData> _dataPoints;
        //        public RoomHistoryForm(List<RoomData> dataPoints)
        public RoomHistoryForm(string roomName)
        {
            InitializeComponent();
            this.Text = roomName;


        }

        private void DrawChart()
        {
            var chartData = Program.MainForm.DataLogger.GetRoomData(this.Text, DateTime.Now.AddDays(-daysToShowTrackBar.Value), DateTime.Now);

            chart1.DataSource = chartData;
            chart1.DataBind();

        }

        private void RoomHistoryForm_Load(object sender, EventArgs e)
        {

            var s = chart1.Series.Add("Actuals");
            s.ChartType = SeriesChartType.Line;
            chart1.Series["Actuals"].ChartType = SeriesChartType.Line;
            chart1.Series["Actuals"].BorderWidth = 3;
            chart1.Series["Actuals"].XValueMember = "DataDate";
            chart1.Series["Actuals"].YValueMembers = "CalculatedTemperature";
            //            chart1.Series["Actuals"].Points.DataBindXY(chartData.Select(dp=>dp.DataDate), chartData.Select(dp => dp.Actual));
            chart1.Series["Actuals"].LegendText = "Actual Temperature";
            chart1.Series["Actuals"].ToolTip = "#VALX{HH:mm}\n#VALY";

            chart1.Series.Add("Set");
            chart1.Series["Set"].ChartType = SeriesChartType.Line;
            chart1.Series["Set"].BorderWidth = 3;
            chart1.Series["Set"].XValueMember = "DataDate";
            chart1.Series["Set"].YValueMembers = "CurrentSetPoint";
            //            chart1.Series["Set"].Points.DataBindXY(chartData, "DataDate", "CurrentSetPoint");
            chart1.Series["Set"].LegendText = "Set Temperature";
            chart1.Series["Set"].ToolTip = "#VALX{HH:mm}\n#VALY";

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MMM\nHH:mm";
            chart1.ChartAreas[0].AxisY.Minimum = 100;

            DrawChart();

        }

        private void daysToShowTrackBar_ValueChanged(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
