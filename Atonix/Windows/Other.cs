using Atonix.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix.Windows
{
    public partial class Other : Form
    {
        public Other()
        {
            InitializeComponent();

            LightModeSwitch.Checked = Settings.Default.LightMode;
        }

        private void LightModeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.LightMode = LightModeSwitch.Checked;
            Settings.Default.Save();
        }

        private void OpenDirectoryBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }
    }
}
