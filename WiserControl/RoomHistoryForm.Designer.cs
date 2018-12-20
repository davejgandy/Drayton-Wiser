namespace WiserControl
{
    partial class RoomHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomHistoryForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.daysToShowTrackBar = new System.Windows.Forms.TrackBar();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.daysToShowLabel = new System.Windows.Forms.Label();
            this.minDaysLabel = new System.Windows.Forms.Label();
            this.maxDaysLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysToShowTrackBar)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(922, 503);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // daysToShowTrackBar
            // 
            this.daysToShowTrackBar.Location = new System.Drawing.Point(210, 3);
            this.daysToShowTrackBar.Maximum = 7;
            this.daysToShowTrackBar.Minimum = 1;
            this.daysToShowTrackBar.Name = "daysToShowTrackBar";
            this.daysToShowTrackBar.Size = new System.Drawing.Size(676, 45);
            this.daysToShowTrackBar.TabIndex = 1;
            this.daysToShowTrackBar.Value = 7;
            this.daysToShowTrackBar.ValueChanged += new System.EventHandler(this.daysToShowTrackBar_ValueChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Controls.Add(this.maxDaysLabel);
            this.bottomPanel.Controls.Add(this.minDaysLabel);
            this.bottomPanel.Controls.Add(this.daysToShowLabel);
            this.bottomPanel.Controls.Add(this.daysToShowTrackBar);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 503);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(922, 33);
            this.bottomPanel.TabIndex = 2;
            // 
            // daysToShowLabel
            // 
            this.daysToShowLabel.AutoSize = true;
            this.daysToShowLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysToShowLabel.Location = new System.Drawing.Point(7, 3);
            this.daysToShowLabel.Name = "daysToShowLabel";
            this.daysToShowLabel.Size = new System.Drawing.Size(148, 24);
            this.daysToShowLabel.TabIndex = 2;
            this.daysToShowLabel.Text = "Days To Show";
            // 
            // minDaysLabel
            // 
            this.minDaysLabel.AutoSize = true;
            this.minDaysLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDaysLabel.Location = new System.Drawing.Point(182, 3);
            this.minDaysLabel.Name = "minDaysLabel";
            this.minDaysLabel.Size = new System.Drawing.Size(22, 24);
            this.minDaysLabel.TabIndex = 3;
            this.minDaysLabel.Text = "1";
            // 
            // maxDaysLabel
            // 
            this.maxDaysLabel.AutoSize = true;
            this.maxDaysLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDaysLabel.Location = new System.Drawing.Point(892, 3);
            this.maxDaysLabel.Name = "maxDaysLabel";
            this.maxDaysLabel.Size = new System.Drawing.Size(22, 24);
            this.maxDaysLabel.TabIndex = 4;
            this.maxDaysLabel.Text = "7";
            // 
            // RoomHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 536);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "RoomHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomHistoryForm";
            this.Load += new System.EventHandler(this.RoomHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysToShowTrackBar)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar daysToShowTrackBar;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label maxDaysLabel;
        private System.Windows.Forms.Label minDaysLabel;
        private System.Windows.Forms.Label daysToShowLabel;
    }
}