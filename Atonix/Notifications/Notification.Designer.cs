namespace Atonix.Notifications
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.IconPb = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.OKBtn = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPb
            // 
            this.IconPb.Image = global::Atonix.Properties.Resources.ok;
            this.IconPb.Location = new System.Drawing.Point(12, 12);
            this.IconPb.Name = "IconPb";
            this.IconPb.Size = new System.Drawing.Size(65, 106);
            this.IconPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPb.TabIndex = 0;
            this.IconPb.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(83, 12);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(361, 34);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Title";
            // 
            // OKBtn
            // 
            this.OKBtn.Animated = true;
            this.OKBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OKBtn.BorderRadius = 4;
            this.OKBtn.BorderThickness = 1;
            this.OKBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OKBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OKBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OKBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OKBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OKBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.OKBtn.ForeColor = System.Drawing.Color.White;
            this.OKBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.OKBtn.Location = new System.Drawing.Point(12, 121);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(432, 38);
            this.OKBtn.TabIndex = 12;
            this.OKBtn.Text = "OK";
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.ForeColor = System.Drawing.Color.Silver;
            this.DescriptionLbl.Location = new System.Drawing.Point(85, 46);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(360, 72);
            this.DescriptionLbl.TabIndex = 2;
            this.DescriptionLbl.Text = "label1qwe\r\nqwe\r\nqwe";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 250;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(456, 167);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.IconPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.ShowInTaskbar = false;
            this.Text = "Notification";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPb;
        private System.Windows.Forms.Label TitleLbl;
        private Guna.UI2.WinForms.Guna2Button OKBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DescriptionLbl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}