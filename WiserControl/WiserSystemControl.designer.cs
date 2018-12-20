namespace WiserControl
{
    partial class WiserSystemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiserSystemControl));
            this.titleLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.hotWaterRelayPictureBox = new System.Windows.Forms.PictureBox();
            this.heatingRelayPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ecoPictureBox = new System.Windows.Forms.PictureBox();
            this.resetToSchedulePictureBox = new System.Windows.Forms.PictureBox();
            this.comfortPictureBox = new System.Windows.Forms.PictureBox();
            this.awayPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotWaterRelayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatingRelayPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetToSchedulePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comfortPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.MintCream;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(250, 37);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Thistle;
            this.bottomPanel.Controls.Add(this.hotWaterRelayPictureBox);
            this.bottomPanel.Controls.Add(this.heatingRelayPictureBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 200);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(250, 50);
            this.bottomPanel.TabIndex = 11;
            // 
            // hotWaterRelayPictureBox
            // 
            this.hotWaterRelayPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hotWaterRelayPictureBox.Location = new System.Drawing.Point(165, 6);
            this.hotWaterRelayPictureBox.Name = "hotWaterRelayPictureBox";
            this.hotWaterRelayPictureBox.Size = new System.Drawing.Size(40, 40);
            this.hotWaterRelayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotWaterRelayPictureBox.TabIndex = 14;
            this.hotWaterRelayPictureBox.TabStop = false;
            // 
            // heatingRelayPictureBox
            // 
            this.heatingRelayPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heatingRelayPictureBox.Location = new System.Drawing.Point(203, 6);
            this.heatingRelayPictureBox.Name = "heatingRelayPictureBox";
            this.heatingRelayPictureBox.Size = new System.Drawing.Size(40, 40);
            this.heatingRelayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heatingRelayPictureBox.TabIndex = 13;
            this.heatingRelayPictureBox.TabStop = false;
            this.heatingRelayPictureBox.DoubleClick += new System.EventHandler(this.heatingRelayPictureBox_DoubleClick);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.MintCream;
            this.mainPanel.Controls.Add(this.ecoPictureBox);
            this.mainPanel.Controls.Add(this.resetToSchedulePictureBox);
            this.mainPanel.Controls.Add(this.comfortPictureBox);
            this.mainPanel.Controls.Add(this.awayPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(250, 163);
            this.mainPanel.TabIndex = 12;
            this.mainPanel.DoubleClick += new System.EventHandler(this.mainPanel_DoubleClick);
            // 
            // ecoPictureBox
            // 
            this.ecoPictureBox.Location = new System.Drawing.Point(20, 17);
            this.ecoPictureBox.Name = "ecoPictureBox";
            this.ecoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.ecoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ecoPictureBox.TabIndex = 1;
            this.ecoPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ecoPictureBox, "Click to switch On/Off");
            this.ecoPictureBox.Click += new System.EventHandler(this.ecoPictureBox_Click);
            // 
            // resetToSchedulePictureBox
            // 
            this.resetToSchedulePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("resetToSchedulePictureBox.Image")));
            this.resetToSchedulePictureBox.Location = new System.Drawing.Point(20, 89);
            this.resetToSchedulePictureBox.Name = "resetToSchedulePictureBox";
            this.resetToSchedulePictureBox.Size = new System.Drawing.Size(50, 50);
            this.resetToSchedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resetToSchedulePictureBox.TabIndex = 3;
            this.resetToSchedulePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.resetToSchedulePictureBox, "Reset to Schedule");
            this.resetToSchedulePictureBox.Click += new System.EventHandler(this.resetToSchedulePictureBox_Click);
            // 
            // comfortPictureBox
            // 
            this.comfortPictureBox.Location = new System.Drawing.Point(99, 17);
            this.comfortPictureBox.Name = "comfortPictureBox";
            this.comfortPictureBox.Size = new System.Drawing.Size(50, 50);
            this.comfortPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comfortPictureBox.TabIndex = 2;
            this.comfortPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.comfortPictureBox, "Comfort Mode");
            this.comfortPictureBox.Click += new System.EventHandler(this.comfortPictureBox_Click);
            // 
            // awayPictureBox
            // 
            this.awayPictureBox.Location = new System.Drawing.Point(181, 17);
            this.awayPictureBox.Name = "awayPictureBox";
            this.awayPictureBox.Size = new System.Drawing.Size(50, 50);
            this.awayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awayPictureBox.TabIndex = 0;
            this.awayPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.awayPictureBox, "Away Mode");
            this.awayPictureBox.Click += new System.EventHandler(this.awayPictureBox_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "System Mode";
            // 
            // WiserSystemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "WiserSystemControl";
            this.Size = new System.Drawing.Size(250, 250);
            this.Load += new System.EventHandler(this.WiserWaterControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WiserRoomControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WiserRoomControl_MouseDown);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotWaterRelayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatingRelayPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ecoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetToSchedulePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comfortPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox resetToSchedulePictureBox;
        private System.Windows.Forms.PictureBox comfortPictureBox;
        private System.Windows.Forms.PictureBox ecoPictureBox;
        private System.Windows.Forms.PictureBox awayPictureBox;
        private System.Windows.Forms.PictureBox heatingRelayPictureBox;
        private System.Windows.Forms.PictureBox hotWaterRelayPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
