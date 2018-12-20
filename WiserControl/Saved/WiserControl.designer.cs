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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiserRoomControl));
            this.currrentTempLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.setPointLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.upPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.downPictureBox = new System.Windows.Forms.PictureBox();
            this.heatDemandPictureBox = new System.Windows.Forms.PictureBox();
            this.autoManualPictureBox = new System.Windows.Forms.PictureBox();
            this.noOverridePictureBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatDemandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).BeginInit();
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
            this.currrentTempLabel.Size = new System.Drawing.Size(250, 113);
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
            this.setPointLabel.Location = new System.Drawing.Point(6, 7);
            this.setPointLabel.Name = "setPointLabel";
            this.setPointLabel.Size = new System.Drawing.Size(107, 40);
            this.setPointLabel.TabIndex = 7;
            this.setPointLabel.Text = "label1";
            this.setPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bottomPanel.Controls.Add(this.setPointLabel);
            this.bottomPanel.Controls.Add(this.heatDemandPictureBox);
            this.bottomPanel.Controls.Add(this.autoManualPictureBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 200);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(250, 50);
            this.bottomPanel.TabIndex = 12;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.currrentTempLabel);
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(250, 163);
            this.mainPanel.TabIndex = 14;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.upPictureBox);
            this.buttonPanel.Controls.Add(this.pictureBox1);
            this.buttonPanel.Controls.Add(this.downPictureBox);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 113);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(250, 50);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.downPictureBox_Click);
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
            // heatDemandPictureBox
            // 
            this.heatDemandPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.heatDemandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("heatDemandPictureBox.Image")));
            this.heatDemandPictureBox.Location = new System.Drawing.Point(164, 6);
            this.heatDemandPictureBox.Name = "heatDemandPictureBox";
            this.heatDemandPictureBox.Size = new System.Drawing.Size(35, 35);
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
            this.autoManualPictureBox.Location = new System.Drawing.Point(203, 7);
            this.autoManualPictureBox.Name = "autoManualPictureBox";
            this.autoManualPictureBox.Size = new System.Drawing.Size(40, 40);
            this.autoManualPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.autoManualPictureBox.TabIndex = 11;
            this.autoManualPictureBox.TabStop = false;
            this.autoManualPictureBox.Click += new System.EventHandler(this.autoManualPictureBox_Click);
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
            this.mainPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatDemandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
