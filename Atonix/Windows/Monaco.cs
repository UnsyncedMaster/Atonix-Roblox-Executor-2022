using Atonix.Notifications;
using Atonix.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix.Windows
{
    public partial class Monaco : Form
    {
        public Monaco()
        {
            InitializeComponent();
        }

        void RefreshMonaco()
        {
            RegistryKey RegKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
            if (RegKey.GetValue(AppDomain.CurrentDomain.FriendlyName) == null)
                RegKey.SetValue(AppDomain.CurrentDomain.FriendlyName, 11001, RegistryValueKind.DWord);
            MainForm.instance.editor.Navigate(string.Format("file:///{0}/bin/Monaco Editor/Monaco.html", Directory.GetCurrentDirectory()));
        }

        public static string MonacoEditorPath = "./bin/Monaco Editor/Monaco.html";

        public static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public string readLine(string fileName, int line)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            return arrLine[line - 0x01];
        }

        private void MiniMapSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (MiniMapSwitch.Checked == true)
            {
                lineChanger("enabled: true,", MonacoEditorPath, 112);
            }
            else
            {
                lineChanger("enabled: false,", MonacoEditorPath, 112);
            }
        }

        private void SmoothScrollingSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (SmoothScrollingSwitch.Checked == true)
            {
                lineChanger("smoothScrolling: true,", MonacoEditorPath, 115);
            }
            else
            {
                lineChanger("smoothScrolling: false,", MonacoEditorPath, 115);
            }
        }

        private void ScrollBarArrowsSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ScrollBarArrowsSwitch.Checked == true)
            {
                lineChanger("verticalHasArrows: true,", MonacoEditorPath, 107);
            }
            else
            {
                lineChanger("verticalHasArrows: false,", MonacoEditorPath, 107);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshMonaco();
        }

        private async void Monaco_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            if (readLine(MonacoEditorPath, 115) == "smoothScrolling: true,")
            {
                SmoothScrollingSwitch.Checked = true;
            }

            if (readLine(MonacoEditorPath, 112) == "enabled: true,")
            {
                MiniMapSwitch.Checked = true;
            }

            if (readLine(MonacoEditorPath, 107) == "verticalHasArrows: true,")
            {
                ScrollBarArrowsSwitch.Checked = true;
            }
        }

        private void GeneralPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
