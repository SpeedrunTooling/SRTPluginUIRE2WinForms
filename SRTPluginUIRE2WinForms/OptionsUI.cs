using System;
using System.Windows.Forms;

namespace SRTPluginUIRE2WinForms
{
    public partial class OptionsUI : Form
    {
        private bool alwaysOnTop;

        public OptionsUI()
        {
            InitializeComponent();

            // Set titlebar.
            this.Text += string.Format(" {0}", Program.srtVersion);

            debugCheckBox.Checked = Program.config.Debug;
            noTitlebarCheckBox.Checked = Program.config.NoTitlebar;
            transparentBackgroundCheckBox.Checked = Program.config.Transparent;
            noInventoryCheckBox.Checked = Program.config.NoInventory;
            scalingFactorNumericUpDown.Value = (decimal)Program.config.ScalingFactor;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Warn the user, informing them to restart the SRT.
            MessageBox.Show("Some options do not take effect immediately and you may experience weird display glitches until you restart the SRT.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.config.Debug = debugCheckBox.Checked;
            Program.config.NoInventory = noInventoryCheckBox.Checked;
            Program.config.NoTitlebar = noTitlebarCheckBox.Checked;
            Program.config.ScalingFactor = (float)scalingFactorNumericUpDown.Value;
            Program.config.Transparent = transparentBackgroundCheckBox.Checked;

            // Close form.
            this.Close();
        }
    }
}
