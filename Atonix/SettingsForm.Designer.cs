namespace Atonix
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.IconPb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.GeneralBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.APISettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DscBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ResetSettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.OtherBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MonacoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.WindowPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Panel1.Controls.Add(this.CloseBtn);
            this.guna2Panel1.Controls.Add(this.IconPb);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(634, 29);
            this.guna2Panel1.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(605, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(29, 29);
            this.CloseBtn.TabIndex = 14;
            // 
            // IconPb
            // 
            this.IconPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IconPb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IconPb.Image = ((System.Drawing.Image)(resources.GetObject("IconPb.Image")));
            this.IconPb.ImageRotate = 0F;
            this.IconPb.Location = new System.Drawing.Point(3, 3);
            this.IconPb.Name = "IconPb";
            this.IconPb.Size = new System.Drawing.Size(25, 25);
            this.IconPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPb.TabIndex = 11;
            this.IconPb.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 250;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // GeneralBtn
            // 
            this.GeneralBtn.Animated = true;
            this.GeneralBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GeneralBtn.BorderRadius = 4;
            this.GeneralBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GeneralBtn.Checked = true;
            this.GeneralBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GeneralBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GeneralBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GeneralBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GeneralBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GeneralBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GeneralBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GeneralBtn.ForeColor = System.Drawing.Color.White;
            this.GeneralBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GeneralBtn.Location = new System.Drawing.Point(0, 3);
            this.GeneralBtn.Name = "GeneralBtn";
            this.GeneralBtn.Size = new System.Drawing.Size(161, 31);
            this.GeneralBtn.TabIndex = 17;
            this.GeneralBtn.Text = "General";
            this.GeneralBtn.Click += new System.EventHandler(this.GeneralBtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.Controls.Add(this.APISettingsBtn);
            this.guna2Panel2.Controls.Add(this.DscBtn);
            this.guna2Panel2.Controls.Add(this.ResetSettingsBtn);
            this.guna2Panel2.Controls.Add(this.OtherBtn);
            this.guna2Panel2.Controls.Add(this.MonacoBtn);
            this.guna2Panel2.Controls.Add(this.GeneralBtn);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Panel2.Location = new System.Drawing.Point(8, 40);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(161, 299);
            this.guna2Panel2.TabIndex = 18;
            // 
            // APISettingsBtn
            // 
            this.APISettingsBtn.Animated = true;
            this.APISettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.APISettingsBtn.BorderRadius = 4;
            this.APISettingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.APISettingsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.APISettingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.APISettingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.APISettingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.APISettingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.APISettingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.APISettingsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.APISettingsBtn.ForeColor = System.Drawing.Color.White;
            this.APISettingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.APISettingsBtn.Location = new System.Drawing.Point(0, 77);
            this.APISettingsBtn.Name = "APISettingsBtn";
            this.APISettingsBtn.Size = new System.Drawing.Size(161, 31);
            this.APISettingsBtn.TabIndex = 22;
            this.APISettingsBtn.Text = "API Settings";
            this.APISettingsBtn.Click += new System.EventHandler(this.APISettingsBtn_Click);
            // 
            // DscBtn
            // 
            this.DscBtn.Animated = true;
            this.DscBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DscBtn.BorderRadius = 4;
            this.DscBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DscBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DscBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DscBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DscBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DscBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DscBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DscBtn.ForeColor = System.Drawing.Color.White;
            this.DscBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DscBtn.Location = new System.Drawing.Point(0, 228);
            this.DscBtn.Name = "DscBtn";
            this.DscBtn.Size = new System.Drawing.Size(161, 31);
            this.DscBtn.TabIndex = 21;
            this.DscBtn.Text = "Help / Community";
            this.DscBtn.Click += new System.EventHandler(this.DscBtn_Click);
            // 
            // ResetSettingsBtn
            // 
            this.ResetSettingsBtn.Animated = true;
            this.ResetSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ResetSettingsBtn.BorderRadius = 4;
            this.ResetSettingsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResetSettingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetSettingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetSettingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetSettingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetSettingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ResetSettingsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ResetSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.ResetSettingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResetSettingsBtn.Location = new System.Drawing.Point(0, 265);
            this.ResetSettingsBtn.Name = "ResetSettingsBtn";
            this.ResetSettingsBtn.Size = new System.Drawing.Size(161, 31);
            this.ResetSettingsBtn.TabIndex = 20;
            this.ResetSettingsBtn.Text = "Reset Settings";
            this.ResetSettingsBtn.Click += new System.EventHandler(this.ResetSettingsBtn_Click);
            // 
            // OtherBtn
            // 
            this.OtherBtn.Animated = true;
            this.OtherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OtherBtn.BorderRadius = 4;
            this.OtherBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.OtherBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OtherBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OtherBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OtherBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OtherBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OtherBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OtherBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OtherBtn.ForeColor = System.Drawing.Color.White;
            this.OtherBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OtherBtn.Location = new System.Drawing.Point(0, 114);
            this.OtherBtn.Name = "OtherBtn";
            this.OtherBtn.Size = new System.Drawing.Size(161, 31);
            this.OtherBtn.TabIndex = 19;
            this.OtherBtn.Text = "Other";
            this.OtherBtn.Click += new System.EventHandler(this.OtherBtn_Click);
            // 
            // MonacoBtn
            // 
            this.MonacoBtn.Animated = true;
            this.MonacoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MonacoBtn.BorderRadius = 4;
            this.MonacoBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MonacoBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MonacoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MonacoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MonacoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MonacoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MonacoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MonacoBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MonacoBtn.ForeColor = System.Drawing.Color.White;
            this.MonacoBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MonacoBtn.Location = new System.Drawing.Point(0, 40);
            this.MonacoBtn.Name = "MonacoBtn";
            this.MonacoBtn.Size = new System.Drawing.Size(161, 31);
            this.MonacoBtn.TabIndex = 18;
            this.MonacoBtn.Text = "Monaco";
            this.MonacoBtn.Click += new System.EventHandler(this.MonacoBtn_Click);
            // 
            // WindowPnl
            // 
            this.WindowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.WindowPnl.BorderRadius = 8;
            this.WindowPnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.WindowPnl.Location = new System.Drawing.Point(175, 40);
            this.WindowPnl.Name = "WindowPnl";
            this.WindowPnl.Size = new System.Drawing.Size(451, 299);
            this.WindowPnl.TabIndex = 22;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(634, 349);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.WindowPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atonix Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox IconPb;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button GeneralBtn;
        private Guna.UI2.WinForms.Guna2Button DscBtn;
        private Guna.UI2.WinForms.Guna2Button ResetSettingsBtn;
        private Guna.UI2.WinForms.Guna2Button OtherBtn;
        private Guna.UI2.WinForms.Guna2Button MonacoBtn;
        private Guna.UI2.WinForms.Guna2Panel WindowPnl;
        private Guna.UI2.WinForms.Guna2Button APISettingsBtn;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBtn;
    }
}