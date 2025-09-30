//using Atonix.Classes.Oxygen;
using Atonix.Notifications;
using Atonix.Properties;
//using KrnlAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WeAreDevs_API;

namespace Atonix
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

  //      ExploitAPI WRDapi = new ExploitAPI();

        void ExecuteScriptHubScript(string script)
        {
            using (WebClient wc = new WebClient())
            {
                if (Settings.Default.API == "WRD")
                {
                    NotifyClass.Alert("Please Attach", "Please attach to roblox first before executing", Notification.EnumType.Info);
                }
                else if (Settings.Default.API == "Krnl")
                {
                    NotifyClass.Alert("Please Attach", "Please attach to roblox first before executing", Notification.EnumType.Info);
                }
                else if (Settings.Default.API == "Oxy")
                {
                    NotifyClass.Alert("Please Attach", "Please attach to roblox first before executing", Notification.EnumType.Info);

                }
                wc.Dispose();
            }
        }

        private void JailbreakBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://shlex.dev/release/domainx/latest.lua");

        private void BABFTBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://raw.githubusercontent.com/OopssSorry/OopssGui/main/MainOopssGui.lua");

        private void MM2Btn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://pastebin.com/raw/fY6QBZv8");

        private void PetSimXBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://raw.githubusercontent.com/ZaRdoOx/Ultra-Hub/main/Main");

        private void KATBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://pastebin.com/raw/wMRbchmC");

        private void MS2Btn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://pastebin.com/raw/cMxt4Qqr");

        private void VestraHubBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://script.vestra.tech");

        private void OwlHubBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");

        private void DarkHubBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://raw.githubusercontent.com/RandomAdamYT/DarkHub/master/Init");

        private void UnfairHubBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://raw.githubusercontent.com/rblxscriptsnet/unfair/main/rblxhub.lua");

        private void GalaxyHubBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("http://galaxyhub.pro/api/whitelist");

        private void CelestialHubBtn_Click(object sender, EventArgs e) => ExecuteScriptHubScript("https://raw.githubusercontent.com/JellyBagBeans/CelestialHub/main/GameLoader");
    }
}
