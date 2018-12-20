using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wiser;

namespace WiserPlug
{
    public partial class MainForm : Form
    {
        private bool _firstRender = true;
        private WiserConnection _wiserConn;
        public MainForm()
        {
            InitializeComponent();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleSwitch1_Click(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _wiserConn = new WiserConnection();
            var hub = _wiserConn.GetData();

            foreach (var plug in hub.SmartPlug)
            {
                var newPlugIndex = plugComboBox.Items.Add(plug.Name);
                if (plug.Name == Settings.Default.LastPlug)
                    plugComboBox.SelectedIndex = newPlugIndex;

            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            enableToolStripMenuItem.Checked= toggleSwitch1.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.LastPlug = plugComboBox.Text;
            Settings.Default.Save();
        }

        private void plugComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleSwitch1.Checked = (bool)_wiserConn.GetSmartPlugRelayState(plugComboBox.Text);
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (_firstRender)
                return;

        }

        private void toggleSwitch1_Click(object sender, EventArgs e)
        {
            //toggleSwitch1.Checked = !toggleSwitch1.Checked;
            //_wiserConn.SetSmartPlugRelayState(plugComboBox.Text, toggleSwitch1.Checked);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _firstRender = false;
        }
    }
}
