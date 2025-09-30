using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix
{
    public partial class Loader : Form
    {
        public static string Ver = "v2.0.0";
        string VerLink = "https://pastebin.com/raw/YtREaMrW";

        public Loader()
        {
            InitializeComponent();
        }

        public void LoadAtonix()
        {
            using (WebClient wc = new WebClient())
            {
                // Check For Internet
                bool Internet = NetworkInterface.GetIsNetworkAvailable();
                if (Internet == false)
                {
                    if (MessageBox.Show("Atonix requires an internet connection, Press OK To Close.", "No Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else // Internet Connection Is Available 
                {
                    // Check Version
                    if (!wc.DownloadString(VerLink).Contains(Ver))
                    {
                        ProgBar.Value = 0;
                        if (MessageBox.Show("You have an outdated version of Atonix, would you like to be redirected to our discord server to update?", "Atonix", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start("https://discord.gg/3cnc4FsKBd");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        private async void Loader_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(guna2PictureBox1);
            await Task.Delay(250);
            timer1.Start();
            LoadAtonix();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            ProgBar.Value += 1;

            if (ProgBar.Value == 100)
            {
                timer1.Stop();
                await Task.Delay(250);
                for (; Opacity > 0.0; Opacity -= 0.1)
                    await Task.Delay(10);

                Opacity = 0;
                Hide();
                new MainForm().Show();
            }
        }
    }
}
