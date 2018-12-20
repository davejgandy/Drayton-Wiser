namespace WiserControl
{
    partial class WiserWaterControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.toggleSwitch1 = new JCS.ToggleSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.togglePanel = new System.Windows.Forms.Panel();
            this.autoManualPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.togglePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(250, 37);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Hot Water";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(51, 30);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffFont = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OffText = "Off";
            this.toggleSwitch1.OnFont = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(112, 54);
            this.toggleSwitch1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.toggleSwitch1.TabIndex = 10;
            this.toggleSwitch1.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch1_CheckedChanged);
            this.toggleSwitch1.Click += new System.EventHandler(this.toggleSwitch1_Click);
            this.toggleSwitch1.Layout += new System.Windows.Forms.LayoutEventHandler(this.toggleSwitch1_Layout);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.autoManualPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 50);
            this.panel1.TabIndex = 11;
            // 
            // togglePanel
            // 
            this.togglePanel.BackColor = System.Drawing.Color.AliceBlue;
            this.togglePanel.Controls.Add(this.toggleSwitch1);
            this.togglePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.togglePanel.Location = new System.Drawing.Point(0, 37);
            this.togglePanel.Name = "togglePanel";
            this.togglePanel.Size = new System.Drawing.Size(250, 163);
            this.togglePanel.TabIndex = 12;
            // 
            // autoManualPictureBox
            // 
            this.autoManualPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoManualPictureBox.Location = new System.Drawing.Point(203, 7);
            this.autoManualPictureBox.Name = "autoManualPictureBox";
            this.autoManualPictureBox.Size = new System.Drawing.Size(40, 40);
            this.autoManualPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.autoManualPictureBox.TabIndex = 12;
            this.autoManualPictureBox.TabStop = false;
            this.autoManualPictureBox.Click += new System.EventHandler(this.autoManualPictureBox_Click);
            // 
            // WiserWaterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.togglePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "WiserWaterControl";
            this.Size = new System.Drawing.Size(250, 250);
            this.Load += new System.EventHandler(this.WiserWaterControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WiserRoomControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WiserRoomControl_MouseDown);
            this.panel1.ResumeLayout(false);
            this.togglePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoManualPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private JCS.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox autoManualPictureBox;
        private System.Windows.Forms.Panel togglePanel;
    }
}
