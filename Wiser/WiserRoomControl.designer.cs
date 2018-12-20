namespace Wiser
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
            this.upPictureBox = new System.Windows.Forms.PictureBox();
            this.downPictureBox = new System.Windows.Forms.PictureBox();
            this.setPointLabel = new System.Windows.Forms.Label();
            this.noOverridePictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.autoManualPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOverridePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // currrentTempLabel
            // 
            this.currrentTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.currrentTempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currrentTempLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currrentTempLabel.Location = new System.Drawing.Point(0, 0);
            this.currrentTempLabel.Name = "currrentTempLabel";
            this.currrentTempLabel.Size = new System.Drawing.Size(145, 98);
            this.currrentTempLabel.TabIndex = 0;
            this.currrentTempLabel.Text = "cT";
            this.currrentTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currrentTempLabel.Layout += new System.Windows.Forms.LayoutEventHandler(this.currrentTempLabel_Layout);
            // 
            // roomLabel
            // 
            this.roomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roomLabel.Location = new System.Drawing.Point(0, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(200, 37);
            this.roomLabel.TabIndex = 4;
            this.roomLabel.Text = "label1";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upPictureBox
            // 
            this.upPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("upPictureBox.Image")));
            this.upPictureBox.Location = new System.Drawing.Point(10, 12);
            this.upPictureBox.Name = "upPictureBox";
            this.upPictureBox.Size = new System.Drawing.Size(30, 29);
            this.upPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPictureBox.TabIndex = 5;
            this.upPictureBox.TabStop = false;
            this.upPictureBox.Click += new System.EventHandler(this.upPictureBox_Click);
            // 
            // downPictureBox
            // 
            this.downPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("downPictureBox.Image")));
            this.downPictureBox.Location = new System.Drawing.Point(10, 63);
            this.downPictureBox.Name = "downPictureBox";
            this.downPictureBox.Size = new System.Drawing.Size(30, 29);
            this.downPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPictureBox.TabIndex = 6;
            this.downPictureBox.TabStop = false;
            this.downPictureBox.Click += new System.EventHandler(this.downPictureBox_Click);
            // 
            // setPointLabel
            // 
            this.setPointLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPointLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.setPointLabel.Location = new System.Drawing.Point(145, 3);
            this.setPointLabel.Name = "setPointLabel";
            this.setPointLabel.Size = new System.Drawing.Size(50, 50);
            this.setPointLabel.TabIndex = 7;
            this.setPointLabel.Text = "label1";
            this.setPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "finger-of-a-hand-pointing-to-right-direction.png");
            this.imageList1.Images.SetKeyName(1, "calendar-with-spring-binder-and-date-blocks.png");
            this.imageList1.Images.SetKeyName(2, "chevron-arrow-up.png");
            this.imageList1.Images.SetKeyName(3, "chevron-arrow-down.png");
            // 
            // autoManualPictureBox
            // 
            this.autoManualPictureBox.Location = new System.Drawing.Point(7, 18);
            this.autoManualPictureBox.Name = "autoManualPictureBox";
            this.autoManualPictureBox.Size = new System.Drawing.Size(35, 35);
            this.autoManualPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.autoManualPictureBox.TabIndex = 11;
            this.autoManualPictureBox.TabStop = false;
            this.autoManualPictureBox.Click += new System.EventHandler(this.autoManualPictureBox_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.autoManualPictureBox);
            this.bottomPanel.Controls.Add(this.setPointLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 135);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(200, 65);
            this.bottomPanel.TabIndex = 12;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.downPictureBox);
            this.rightPanel.Controls.Add(this.upPictureBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(145, 37);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(55, 98);
            this.rightPanel.TabIndex = 13;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.currrentTempLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(145, 98);
            this.mainPanel.TabIndex = 14;
            // 
            // WiserRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.noOverridePictureBox);
            this.Name = "WiserRoomControl";
            this.Size = new System.Drawing.Size(200, 200);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WiserRoomControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WiserRoomControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOverridePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox autoManualPictureBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}
