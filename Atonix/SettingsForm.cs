using Atonix.Properties;
using Atonix.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix
{
    public partial class SettingsForm : Form
    {
        General gen = new General() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Monaco monaco = new Monaco() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        APISettings api = new APISettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Other other = new Other() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        void SwitchWindow(string Window)
        {
            if (Window == "General")
            {
                monaco.Hide();
                api.Hide();
                other.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(gen);
                gen.Show();
            }
            if (Window == "Monaco")
            {
                gen.Hide();
                api.Hide();
                other.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(monaco);
                monaco.Show();
            }
            else if (Window == "API")
            {
                monaco.Hide();
                gen.Hide();
                other.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(api);
                api.Show();
            }
            else if (Window == "Other")
            {
                monaco.Hide();
                api.Hide();
                gen.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(other);
                other.Show();
            }
        }
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            SwitchWindow("General");
        }

        private void GeneralBtn_Click(object sender, EventArgs e)
        {
            SwitchWindow("General");
        }

        private void MonacoBtn_Click(object sender, EventArgs e)
        {
            SwitchWindow("Monaco");
        }

        private void APISettingsBtn_Click(object sender, EventArgs e)
        {
            SwitchWindow("API");
        }

        private void OtherBtn_Click(object sender, EventArgs e)
        {
            SwitchWindow("Other");
        }

        void ResetSettings()
        {
            Settings.Default.TopMost = false;
            Settings.Default.Transparency = false;
            Settings.Default.DiscordRPC = false;
            Settings.Default.LightMode = false;
            Settings.Default.AutoAttach = false;

            Settings.Default.API = "WRD";

            Monaco.lineChanger("verticalHasArrows: false,", Monaco.MonacoEditorPath, 107);
            Monaco.lineChanger("smoothScrolling: false,", Monaco.MonacoEditorPath, 115);
            Monaco.lineChanger("enabled: false,", Monaco.MonacoEditorPath, 112);

            Application.Restart();
        }

        private void ResetSettingsBtn_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private void DscBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://dsc.gg/atonix");
        }
    }
}
