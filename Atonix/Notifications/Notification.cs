using Atonix.Properties;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix.Notifications
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        public enum EnumAction
        {
            wait,
            start,
            close
        }

        public enum EnumType
        {
            Info,
            Error,
            Success,
            Warning
        }

        private EnumAction action;

        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case EnumAction.wait:
                    timer1.Interval = 5000;
                    action = EnumAction.close;
                    break;
                case EnumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = EnumAction.wait;
                        }
                    }
                    break;
                case EnumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }

                    break;
            }
        }

        public void showNotifications(string title, string description, EnumType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "Notifications" + i.ToString();
                Notification form = (Notification)Application.OpenForms[fname];

                if (form == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 25;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 10 * i;
                    Location = new Point(x, y);
                    break;
                }
            }

            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch (type)
            {
                case EnumType.Success:
                    IconPb.Image = Resources.ok;
                    break;
                case EnumType.Info:
                    IconPb.Image = Resources.info;
                    break;
                case EnumType.Error:
                    IconPb.Image = Resources.error;
                    break;
            }

            TitleLbl.Text = title;
            DescriptionLbl.Text = description;

            Show();
            action = EnumAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = EnumAction.close;
        }
    }
}
