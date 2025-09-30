using Atonix.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix.Windows
{
    public partial class APISettings : Form
    {
        public APISettings()
        {
            InitializeComponent();
        }

        private void APISelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (APISelector.SelectedIndex == 0)
            {
                Settings.Default.API = "WRD";
                Settings.Default.Save();
            }
            else if (APISelector.SelectedIndex == 1)
            {
                Settings.Default.API = "Krnl";
                Settings.Default.Save();
            }
            else if (APISelector.SelectedIndex == 2)
            {
                Settings.Default.API = "Oxy";
                Settings.Default.Save();
            }
        }

        private void AutoAttachSwitch_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.instance.aa.Enabled = AutoAttachSwitch.Checked;
            Settings.Default.AutoAttach = AutoAttachSwitch.Checked;

            Settings.Default.Save();
        }

        private void APISettings_Load(object sender, EventArgs e)
        {
            AutoAttachSwitch.Checked = Settings.Default.AutoAttach;

            if (Settings.Default.API == "WRD")
            {
                APISelector.SelectedIndex = 0;
            }
            else if (Settings.Default.API == "Krnl")
            {
                APISelector.SelectedIndex = 1;
            }
            else if (Settings.Default.API == "Oxy")
            {
                APISelector.SelectedIndex = 2;
            }
        }
    }
}
