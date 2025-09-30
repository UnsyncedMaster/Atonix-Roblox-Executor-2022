using Atonix.Classes;
using Atonix.Notifications;
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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            //TopMost
            if (Settings.Default.TopMost == true)
            {
                TopMostSwitch.Checked = true;
            }

            //Opacity
            if (Settings.Default.Transparency == true)
            {
                TransparentSwitch.Checked = true;
            }

            //DiscordRPC
            if (Settings.Default.DiscordRPC == true)
            {
                DiscordRPCSwitch.Checked = true;
            }
        }

        void KillRBLX()
        {
            Process[] rbProcess = Process.GetProcessesByName("RobloxPlayerBeta");
            if (rbProcess.Length >= 1)
            {
                foreach (Process Roblox in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    Roblox.Kill();
                    NotifyClass.Alert("Killed ROBLOX Process", "Successfully killed the ROBLOX process", Notification.EnumType.Success);
                    break;
                }
            }
            else if (rbProcess.Length == 0)
            {
                NotifyClass.Alert("Could not find ROBLOX", "Could not find any open ROBLOX instances", Notification.EnumType.Error);
            }
        }

        private void TopMostSwitch_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.instance.TopMost = TopMostSwitch.Checked;
            Settings.Default.TopMost = TopMostSwitch.Checked;
            Settings.Default.Save();
        }

        private void TransparentSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (TransparentSwitch.Checked == true)
            {
                MainForm.instance.Opacity = 0.80;
            }
            else
            {
                MainForm.instance.Opacity = 1.00;
            }
            Settings.Default.Transparency = TransparentSwitch.Checked;
            Settings.Default.Save();
        }

        private void DiscordRPCSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscordRPCSwitch.Checked == true)
            {
                RPCClass.InitializeRPC();
                Settings.Default.DiscordRPC = true;
            }
            else
            {
                RPCClass.DisposeRPC();
                Settings.Default.DiscordRPC = false;
            }
            Settings.Default.Save();
        }

        private void KillRBLXBtn_Click(object sender, EventArgs e)
        {
            KillRBLX();
        }

        private void UnlockFPSBtn_Click(object sender, EventArgs e)
        {
            Process.Start("bin\\Apps\\FPS_Unlocker.exe");
        }

        private void MultiRBLXBtn_Click(object sender, EventArgs e)
        {
            Process.Start("bin\\Apps\\Multiple_RBLX_Clients.exe");
        }

        private void ClearEditorPromptSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ClearEditorPrompt = ClearEditorPromptSwitch.Checked;
            Settings.Default.Save();
        }
    }
}
