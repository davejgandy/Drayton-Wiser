namespace Wiser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiserWaterControl));
            this.titleLabel = new System.Windows.Forms.Label();
            this.manualOverridePictureBox = new System.Windows.Forms.PictureBox();
            this.noOverridePictureBox = new System.Windows.Forms.PictureBox();
            this.toggleSwitch1 = new JCS.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.manualOverridePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOverridePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 37);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Hot Water";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualOverridePictureBox
            // 
            this.manualOverridePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("manualOverridePictureBox.Image")));
            this.manualOverridePictureBox.Location = new System.Drawing.Point(132, 166);
            this.manualOverridePictureBox.Name = "manualOverridePictureBox";
            this.manualOverridePictureBox.Size = new System.Drawing.Size(31, 29);
            this.manualOverridePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manualOverridePictureBox.TabIndex = 8;
            this.manualOverridePictureBox.TabStop = false;
            this.manualOverridePictureBox.Click += new System.EventHandler(this.manualOverridePictureBox_Click);
            // 
            // noOverridePictureBox
            // 
            this.noOverridePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("noOverridePictureBox.Image")));
            this.noOverridePictureBox.Location = new System.Drawing.Point(132, 166);
            this.noOverridePictureBox.Name = "noOverridePictureBox";
            this.noOverridePictureBox.Size = new System.Drawing.Size(31, 29);
            this.noOverridePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noOverridePictureBox.TabIndex = 9;
            this.noOverridePictureBox.TabStop = false;
            this.noOverridePictureBox.Click += new System.EventHandler(this.noOverridePictureBox_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(51, 70);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OffText = "Off";
            this.toggleSwitch1.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(112, 54);
            this.toggleSwitch1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.toggleSwitch1.TabIndex = 10;
            this.toggleSwitch1.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch1_CheckedChanged);
            this.toggleSwitch1.Click += new System.EventHandler(this.toggleSwitch1_Click);
            this.toggleSwitch1.Layout += new System.Windows.Forms.LayoutEventHandler(this.toggleSwitch1_Layout);
            // 
            // WiserWaterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.manualOverridePictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.noOverridePictureBox);
            this.Name = "WiserWaterControl";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.WiserWaterControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WiserRoomControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WiserRoomControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.manualOverridePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOverridePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox manualOverridePictureBox;
        private System.Windows.Forms.PictureBox noOverridePictureBox;
        private JCS.ToggleSwitch toggleSwitch1;
    }
}
