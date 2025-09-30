using Atonix.Classes;
//using Atonix.Classes.Oxygen;
using Atonix.Notifications;
using Atonix.Properties;
//using KrnlAPI;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WeAreDevs_API;

namespace Atonix
{
    public partial class MainForm : Form
    {
        FileSystemWatcher ScriptsChecker = new FileSystemWatcher
        {
            Path = "./scripts",
            EnableRaisingEvents = true
        };
        public static MainForm instance;
        public WebBrowser editor;

        public Timer aa;

       // ExploitAPI WRDapi = new ExploitAPI();

        //UI

        int r;
        int g;
        int b;

        public static string monacoSavePath = "./bin/Monaco.save";
        public MainForm()
        {
            InitializeComponent();

            MinimumSize = new Size(764, 390);
            Size = Settings.Default.FormSize;
            SetStyle(ControlStyles.ResizeRedraw, true);

            instance = this;
            editor = MonacoEditor;
            aa = AutoAttach;

            ScriptsChecker.Created += delegate (object s, FileSystemEventArgs e)
            {
                RefreshScripts();
            };

            ScriptsChecker.Changed += delegate (object s, FileSystemEventArgs e)
            {
                RefreshScripts();
            };

            ScriptsChecker.Renamed += delegate (object s, RenamedEventArgs e)
            {
                RefreshScripts();
            };

            ScriptsChecker.Deleted += delegate (object s, FileSystemEventArgs e)
            {
                RefreshScripts();
            };

            TopMost = Settings.Default.TopMost;
            
            if (Settings.Default.Transparency == true)
            {
                Opacity = .80;
            }

            if (Settings.Default.DiscordRPC == true)
            {
                RPCClass.InitializeRPC();
            }
        }

        private string defPath = Application.StartupPath + "//bin//Monaco Editor//";

        private void AddIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            MonacoEditor.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void AddGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.AddIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.AddIntel(text, "Function", text, text);
                }
            }
        }

        private void AddGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.AddIntel(text, "Variable", text, text);
            }
        }

        private void AddGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.AddIntel(text, "Class", text, text);
            }
        }

        private void AddMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.AddIntel(text, "Method", text, text);
            }
        }

        private void AddBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.AddIntel(text, "Keyword", text, text);
            }
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public void RefreshScripts()
        {
            Invoke((MethodInvoker)delegate
            {
                ScriptBox.Items.Clear();
                foreach (var Txt in new DirectoryInfo("scripts\\").GetFiles("*.txt"))
                    ScriptBox.Items.Add(Txt.Name);

                foreach (var Lua in new DirectoryInfo("scripts\\").GetFiles("*.lua"))
                    ScriptBox.Items.Add(Lua.Name);
            });
        }

        void SwitchUIMode()
        {
            if (Settings.Default.LightMode == true)
            {
                //Back Colors
                BackColor = Color.White;
                
                CloseBtn.FillColor = Color.White;
                MaximizeBtn.FillColor = Color.White;
                MinimizeBtn.FillColor = Color.White;
                guna2Panel1.FillColor = Color.White;
                ScriptBox.BackColor = Color.FromArgb(255, 255, 255);
                SearchBox.FillColor = Color.FromArgb(255, 255, 255);

                ExecuteBtn.FillColor = Color.FromArgb(255, 255, 255);
                EraseBtn.FillColor = Color.FromArgb(255, 255, 255);
                OpenBtn.FillColor = Color.FromArgb(255, 255, 255);
                SaveBtn.FillColor = Color.FromArgb(255, 255, 255);
                SettingsBtn.FillColor = Color.FromArgb(255, 255, 255);
                ScriptHubBtn.FillColor = Color.FromArgb(255, 255, 255);
                AttachBtn.FillColor = Color.FromArgb(255, 255, 255);

                //Fore Colors
                CloseBtn.IconColor = Color.Black;
                MaximizeBtn.IconColor = Color.Black;
                MinimizeBtn.IconColor = Color.Black;
                SearchBox.ForeColor = Color.Black;
                StatusLbl.ForeColor = Color.Black;
                ScriptBox.ForeColor = Color.Black;

                ExecuteBtn.ForeColor = Color.Black;
                EraseBtn.ForeColor = Color.Black;
                OpenBtn.ForeColor = Color.Black;
                SaveBtn.ForeColor = Color.Black;
                SettingsBtn.ForeColor = Color.Black;
                ScriptHubBtn.ForeColor = Color.Black;
                AttachBtn.ForeColor = Color.Black;

                //Monaco Editor Theme
                MonacoEditor.Document.InvokeScript("SetTheme", new string[]
{
                   "Light"
});
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            Find_DLL();
            SearchBox.PlaceholderText = "Search Here";
            RegistryKey RegKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
            if (RegKey.GetValue(AppDomain.CurrentDomain.FriendlyName) == null)
                RegKey.SetValue(AppDomain.CurrentDomain.FriendlyName, 11001, RegistryValueKind.DWord);
            MonacoEditor.Navigate(string.Format("file:///{0}/bin/Monaco Editor/Monaco.html", Directory.GetCurrentDirectory()));

await Task.Delay(500);
            try
            {
                MonacoEditor.Document.InvokeScript("SetText", new object[]
{
                        File.ReadAllText(monacoSavePath)
});
            }
            catch
            {
                MessageBox.Show("Failed to load the saved monaco text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshScripts();

            SwitchUIMode();

            AddBase();
            AddMath();
            AddGlobalNS();
            AddGlobalV();
            AddGlobalF();
        }

        private async void AttachBtn_Click(object sender, EventArgs e)
        {
            Process[] Proc = Process.GetProcessesByName("RobloxPlayerBeta");
            if (Proc.Length >= 1)
            {
                if (Settings.Default.API == "WRD")
                {
                    //if (!WRDapi.isAPIAttached())
                   // {
                   //     WRDapi.LaunchExploit();
                   // }
                   // else
                    //{
                    //    NotifyClass.Alert("Already Attached", "You have already attached Syron into Roblox", Notification.EnumType.Info);
                   // }
                }
                else if (Settings.Default.API == "Krnl")
                {
                  //  if (!MainAPI.IsAttached())
                    //{
                   //     MainAPI.Inject();
                   // }
                   // else
                   // {
                   //     NotifyClass.Alert("Already Attached", "You have already attached Syron into Roblox", Notification.EnumType.Info);
                   // }
                }
                else
                {
                   // var res = await API.Inject();
                   // switch (res)
                   // {
                   //     case API.injectionResult.AlreadyInjected:
                   //         NotifyClass.Alert("Already Attached", "You have already attached Syron into Roblox", Notification.EnumType.Info);
                   //         return;
                 //   }
                }
            }
            else
            {
                NotifyClass.Alert("Could not find ROBLOX", "Please open ROBLOX first before Attaching", Notification.EnumType.Error);
            }
        }


        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            HtmlDocument document = MonacoEditor.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string Script = obj.ToString();

            if (Settings.Default.API == "WRD")
            {
                //if (WRDapi.isAPIAttached())
               // {
               //     WRDapi.SendLuaScript(Script);
               // }
               // else
               // {
               //     NotifyClass.Alert("Please Attach", "Please attach to roblox first before executing", Notification.EnumType.Info);
               // }
            }
            else if (Settings.Default.API == "Krnl")
            {
             //   if (MainAPI.IsAttached())
               // {
                 //   MainAPI.Execute(Script);
                //}
                //else
                //{
                  //  NotifyClass.Alert("Please Attach", "Please attach to roblox first before executing", Notification.EnumType.Info);
                //}
            }
            else
            {
               // var res = Execution.Execute(Script);
                //switch (res)
               // {
               //     case Execution.ExecutionResult.PipeNotFound:
               //         NotifyClass.Alert("Please Attach", "Please attach to roblox first before executing", Notification.EnumType.Info);
               //         return;
              //  }
            }
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.ClearEditorPrompt == true)
            {
                if (MessageBox.Show("Are you sure you want to erase the editor?", "Clear Editor Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes )
                {
                    MonacoEditor.Document.InvokeScript("SetText", new object[]
{
                        ""
});
                }
            }
            else
            {
                MonacoEditor.Document.InvokeScript("SetText", new object[]
{
                        ""
});
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            var Ofd = new OpenFileDialog
            {
                Title = "Atonix - Open File",
                Filter = "Text Files|*.txt|Lua Files|*.lua|All Files|*.*",
                FilterIndex = 3,
            };

            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                MonacoEditor.Document.InvokeScript("SetText", new object[]
    {
                        File.ReadAllText(Ofd.FileName)
    });
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var Sfd = new SaveFileDialog
            {
                Title = "Atonix - Save File",
                Filter = "Text Files|*.txt|Lua Files|*.lua|All Files|*.*",
                FilterIndex = 3,
            };

            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                HtmlDocument document = MonacoEditor.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = obj.ToString();

                File.WriteAllText(Sfd.FileName, script);
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void ScriptBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScriptBox.SelectedIndex != -1)
            {
                MonacoEditor.Document.InvokeScript("SetText", new object[1]
                {
                    File.ReadAllText("scripts\\" + ScriptBox.SelectedItem.ToString())
                });
            }
        }

        private void ScriptHubBtn_Click(object sender, EventArgs e)
        {
            new ScriptHub().Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Status_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.API == "WRD")
            {
                //if (WRDapi.isAPIAttached())
                //{
                  //  StatusLbl.Text = "Injected";
                //}
                //else
                //{
                  //  StatusLbl.Text = "Not Injected";
                //}
            }
            else if (Settings.Default.API == "WRD")
            {
               // if (MainAPI.IsAttached())
                //{
                  //  StatusLbl.Text = "Injected";
                //}
                //else
                //{
                  //  StatusLbl.Text = "Not Injected";
                //}
            }
            else if (Settings.Default.API == "Oxy")
            {
                StatusLbl.Text = "";
            }
        }

        void Find_DLL()
        {
            //string API1 = "exploit-main.dll";

            //if(File.Exists(API1))
            //{
                //code
            //}
            //else
            //{
              //  MessageBox.Show($"Couldn't find {API1}, Closing Atonix!", "Error!");
                //Application.Exit();
            //}
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = ScriptBox.Items.Count - 1; i >= 0; i--)
            {
                if (ScriptBox.Items[i].ToString().ToLower().Contains(SearchBox.Text.ToLower()))
                {
                    ScriptBox.SetSelected(i, true);
                }
            }
        }

        private void AutoAttach_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.AutoAttach == true)
            {
                if (Settings.Default.API == "WRD")
                {
                    Process[] ROBLOXProc = Process.GetProcessesByName("RobloxPlayerBeta");
                    if (ROBLOXProc.Length > 0)
                    {
                  //      if (!WRDapi.isAPIAttached())
                    //    {
                      ///      WRDapi.LaunchExploit();
                        //}
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.FormSize = Size;
            Settings.Default.Save();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();

            r = rdm.Next(0, 255);
            g = rdm.Next(0, 255);
            b = rdm.Next(0, 255);
            AttachBtn.FillColor = Color.FromArgb(r, g, b);
            CloseBtn.FillColor = Color.FromArgb(r, g, b);
            EraseBtn.FillColor = Color.FromArgb(r, g, b);
            ExecuteBtn.FillColor = Color.FromArgb(r, g, b);
            MaximizeBtn.FillColor = Color.FromArgb(r, g, b);
            MinimizeBtn.FillColor = Color.FromArgb(r, g, b);
            OpenBtn.FillColor = Color.FromArgb(r, g, b);
            SaveBtn.FillColor = Color.FromArgb(r, g, b);
            ScriptHubBtn.FillColor = Color.FromArgb(r, g, b);
            SettingsBtn.FillColor = Color.FromArgb(r, g, b);
            RandomUIbtn.FillColor = Color.FromArgb(r, g, b);

            StatusLbl.ForeColor = Color.FromArgb(r, g, b);
        }

        private void MonacoEditor_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
