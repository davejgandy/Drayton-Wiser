namespace WiserControl
{
    partial class WiserRoomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiserRoomControl));
            this.currrentTempLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.setPointLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.labelPlugPower = new System.Windows.Forms.Label();
            this.plugPictureBox = new System.Windows.Forms.PictureBox();
            this.heatDemandPictureBox = new System.Windows.Forms.PictureBox();
            this.autoManualPictureBox = new System.Windows.Forms.PictureBox();
            this.batteryPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.upPictureBox = new System.Windows.Forms.PictureBox();
            this.boostPictureBox = new System.Windows.Forms.PictureBox();
            this.downPictureBox = new System.Windows.Forms.PictureBox();
            this.boostPanel = new System.Windows.Forms.Panel();
            this.boostLabel3 = new System.Windows.Forms.Label();
            this.boostLabel2 = new System.Windows.Forms.Label();
            this.boostLabel1 = new System.Windows.Forms.Label();
            this.boostLabel0 = new System.Windows.Forms.Label();
            this.noOverridePictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plugPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatDemandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).BeginInit();
            this.boostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOverridePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // currrentTempLabel
            // 
            this.currrentTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.currrentTempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currrentTempLabel.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currrentTempLabel.Location = new System.Drawing.Point(0, 0);
            this.currrentTempLabel.Name = "currrentTempLabel";
            this.currrentTempLabel.Size = new System.Drawing.Size(250, 116);
            this.currrentTempLabel.TabIndex = 0;
            this.currrentTempLabel.Text = "cT";
            this.currrentTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currrentTempLabel.Layout += new System.Windows.Forms.LayoutEventHandler(this.currrentTempLabel_Layout);
            // 
            // roomLabel
            // 
            this.roomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roomLabel.Location = new System.Drawing.Point(0, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(250, 37);
            this.roomLabel.TabIndex = 4;
            this.roomLabel.Text = "label1";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roomLabel_MouseDown);
            // 
            // setPointLabel
            // 
            this.setPointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setPointLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPointLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.setPointLabel.Location = new System.Drawing.Point(6, 6);
            this.setPointLabel.Name = "setPointLabel";
            this.setPointLabel.Size = new System.Drawing.Size(107, 40);
            this.setPointLabel.TabIndex = 7;
            this.setPointLabel.Text = "label1";
            this.setPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setPointLabel.Click += new System.EventHandler(this.setPointLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.labelPlugPower);
            this.bottomPanel.Controls.Add(this.plugPictureBox);
            this.bottomPanel.Controls.Add(this.setPointLabel);
            this.bottomPanel.Controls.Add(this.heatDemandPictureBox);
            this.bottomPanel.Controls.Add(this.autoManualPictureBox);
            this.bottomPanel.Controls.Add(this.batteryPictureBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 200);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(250, 50);
            this.bottomPanel.TabIndex = 12;
            // 
            // labelPlugPower
            // 
            this.labelPlugPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlugPower.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlugPower.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelPlugPower.Location = new System.Drawing.Point(105, 35);
            this.labelPlugPower.Name = "labelPlugPower";
            this.labelPlugPower.Size = new System.Drawing.Size(44, 11);
            this.labelPlugPower.TabIndex = 14;
            this.labelPlugPower.Text = "000W";
            this.labelPlugPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPlugPower.Click += new System.EventHandler(this.labelPlugPower_Click);
            // 
            // plugPictureBox
            // 
            this.plugPictureBox.Location = new System.Drawing.Point(119, 3);
            this.plugPictureBox.Name = "plugPictureBox";
            this.plugPictureBox.Size = new System.Drawing.Size(30, 30);
            this.plugPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plugPictureBox.TabIndex = 13;
            this.plugPictureBox.TabStop = false;
            this.plugPictureBox.Click += new System.EventHandler(this.plugPictureBox_Click);
            // 
            // heatDemandPictureBox
            // 
            this.heatDemandPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.heatDemandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("heatDemandPictureBox.Image")));
            this.heatDemandPictureBox.Location = new System.Drawing.Point(147, 8);
            this.heatDemandPictureBox.Name = "heatDemandPictureBox";
            this.heatDemandPictureBox.Size = new System.Drawing.Size(30, 30);
            this.heatDemandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heatDemandPictureBox.TabIndex = 11;
            this.heatDemandPictureBox.TabStop = false;
            this.heatDemandPictureBox.Visible = false;
            this.heatDemandPictureBox.Click += new System.EventHandler(this.autoManualPictureBox_Click);
            // 
            // autoManualPictureBox
            // 
            this.autoManualPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoManualPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.autoManualPictureBox.Location = new System.Drawing.Point(178, 3);
            this.autoManualPictureBox.Name = "autoManualPictureBox";
            this.autoManualPictureBox.Size = new System.Drawing.Size(40, 40);
            this.autoManualPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.autoManualPictureBox.TabIndex = 11;
            this.autoManualPictureBox.TabStop = false;
            this.autoManualPictureBox.Click += new System.EventHandler(this.autoManualPictureBox_Click);
            // 
            // batteryPictureBox
            // 
            this.batteryPictureBox.Location = new System.Drawing.Point(217, 6);
            this.batteryPictureBox.Name = "batteryPictureBox";
            this.batteryPictureBox.Size = new System.Drawing.Size(30, 30);
            this.batteryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batteryPictureBox.TabIndex = 12;
            this.batteryPictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.currrentTempLabel);
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Controls.Add(this.boostPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(250, 163);
            this.mainPanel.TabIndex = 14;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.upPictureBox);
            this.buttonPanel.Controls.Add(this.boostPictureBox);
            this.buttonPanel.Controls.Add(this.downPictureBox);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 116);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(250, 47);
            this.buttonPanel.TabIndex = 7;
            // 
            // upPictureBox
            // 
            this.upPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("upPictureBox.Image")));
            this.upPictureBox.Location = new System.Drawing.Point(175, 6);
            this.upPictureBox.Name = "upPictureBox";
            this.upPictureBox.Size = new System.Drawing.Size(30, 30);
            this.upPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPictureBox.TabIndex = 5;
            this.upPictureBox.TabStop = false;
            this.upPictureBox.Click += new System.EventHandler(this.upPictureBox_Click);
            // 
            // boostPictureBox
            // 
            this.boostPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("boostPictureBox.Image")));
            this.boostPictureBox.Location = new System.Drawing.Point(105, 6);
            this.boostPictureBox.Name = "boostPictureBox";
            this.boostPictureBox.Size = new System.Drawing.Size(30, 30);
            this.boostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boostPictureBox.TabIndex = 6;
            this.boostPictureBox.TabStop = false;
            this.boostPictureBox.Click += new System.EventHandler(this.boostPictureBox_Click);
            // 
            // downPictureBox
            // 
            this.downPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("downPictureBox.Image")));
            this.downPictureBox.Location = new System.Drawing.Point(35, 6);
            this.downPictureBox.Name = "downPictureBox";
            this.downPictureBox.Size = new System.Drawing.Size(30, 30);
            this.downPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPictureBox.TabIndex = 6;
            this.downPictureBox.TabStop = false;
            this.downPictureBox.Click += new System.EventHandler(this.downPictureBox_Click);
            // 
            // boostPanel
            // 
            this.boostPanel.Controls.Add(this.boostLabel3);
            this.boostPanel.Controls.Add(this.boostLabel2);
            this.boostPanel.Controls.Add(this.boostLabel1);
            this.boostPanel.Controls.Add(this.boostLabel0);
            this.boostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boostPanel.Location = new System.Drawing.Point(0, 0);
            this.boostPanel.Name = "boostPanel";
            this.boostPanel.Size = new System.Drawing.Size(250, 163);
            this.boostPanel.TabIndex = 8;
            this.boostPanel.Visible = false;
            // 
            // boostLabel3
            // 
            this.boostLabel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.boostLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boostLabel3.ForeColor = System.Drawing.Color.White;
            this.boostLabel3.Location = new System.Drawing.Point(190, 35);
            this.boostLabel3.Name = "boostLabel3";
            this.boostLabel3.Size = new System.Drawing.Size(57, 57);
            this.boostLabel3.TabIndex = 3;
            this.boostLabel3.Tag = "180";
            this.boostLabel3.Text = "3h";
            this.boostLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boostLabel3.Click += new System.EventHandler(this.boostLabel_Click);
            // 
            // boostLabel2
            // 
            this.boostLabel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.boostLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boostLabel2.ForeColor = System.Drawing.Color.White;
            this.boostLabel2.Location = new System.Drawing.Point(128, 35);
            this.boostLabel2.Name = "boostLabel2";
            this.boostLabel2.Size = new System.Drawing.Size(57, 57);
            this.boostLabel2.TabIndex = 2;
            this.boostLabel2.Tag = "120";
            this.boostLabel2.Text = "2h";
            this.boostLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boostLabel2.Click += new System.EventHandler(this.boostLabel_Click);
            // 
            // boostLabel1
            // 
            this.boostLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.boostLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boostLabel1.ForeColor = System.Drawing.Color.White;
            this.boostLabel1.Location = new System.Drawing.Point(65, 35);
            this.boostLabel1.Name = "boostLabel1";
            this.boostLabel1.Size = new System.Drawing.Size(57, 57);
            this.boostLabel1.TabIndex = 1;
            this.boostLabel1.Tag = "60";
            this.boostLabel1.Text = "1h";
            this.boostLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boostLabel1.Click += new System.EventHandler(this.boostLabel_Click);
            // 
            // boostLabel0
            // 
            this.boostLabel0.BackColor = System.Drawing.Color.RoyalBlue;
            this.boostLabel0.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boostLabel0.ForeColor = System.Drawing.Color.White;
            this.boostLabel0.Location = new System.Drawing.Point(3, 35);
            this.boostLabel0.Name = "boostLabel0";
            this.boostLabel0.Size = new System.Drawing.Size(57, 57);
            this.boostLabel0.TabIndex = 0;
            this.boostLabel0.Tag = "30";
            this.boostLabel0.Text = "30 min";
            this.boostLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boostLabel0.Click += new System.EventHandler(this.boostLabel_Click);
            // 
            // noOverridePictureBox
            // 
            this.noOverridePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("noOverridePictureBox.Image")));
            this.noOverridePictureBox.Location = new System.Drawing.Point(3, 0);
            this.noOverridePictureBox.Name = "noOverridePictureBox";
            this.noOverridePictureBox.Size = new System.Drawing.Size(31, 29);
            this.noOverridePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noOverridePictureBox.TabIndex = 9;
            this.noOverridePictureBox.TabStop = false;
            this.noOverridePictureBox.Click += new System.EventHandler(this.noOverridePictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WiserRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.noOverridePictureBox);
            this.Name = "WiserRoomControl";
            this.Size = new System.Drawing.Size(250, 250);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WiserRoomControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WiserRoomControl_MouseDown);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plugPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatDemandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).EndInit();
            this.boostPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noOverridePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currrentTempLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.PictureBox upPictureBox;
        private System.Windows.Forms.PictureBox downPictureBox;
        private System.Windows.Forms.Label setPointLabel;
        private System.Windows.Forms.PictureBox noOverridePictureBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox autoManualPictureBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox heatDemandPictureBox;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.PictureBox boostPictureBox;
        private System.Windows.Forms.Panel boostPanel;
        private System.Windows.Forms.Label boostLabel0;
        private System.Windows.Forms.Label boostLabel3;
        private System.Windows.Forms.Label boostLabel2;
        private System.Windows.Forms.Label boostLabel1;
        private System.Windows.Forms.PictureBox batteryPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox plugPictureBox;
        private System.Windows.Forms.Label labelPlugPower;
    }
}
