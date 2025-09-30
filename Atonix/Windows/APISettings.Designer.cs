namespace Atonix.Windows
{
    partial class APISettings
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
            this.GeneralPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.APISelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AutoAttachSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.GeneralPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPnl
            // 
            this.GeneralPnl.AutoScroll = true;
            this.GeneralPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GeneralPnl.BorderRadius = 8;
            this.GeneralPnl.Controls.Add(this.APISelector);
            this.GeneralPnl.Controls.Add(this.label1);
            this.GeneralPnl.Controls.Add(this.label8);
            this.GeneralPnl.Controls.Add(this.AutoAttachSwitch);
            this.GeneralPnl.Controls.Add(this.label5);
            this.GeneralPnl.Controls.Add(this.guna2Separator3);
            this.GeneralPnl.Controls.Add(this.label6);
            this.GeneralPnl.Controls.Add(this.label7);
            this.GeneralPnl.Controls.Add(this.guna2Separator4);
            this.GeneralPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralPnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GeneralPnl.Location = new System.Drawing.Point(0, 0);
            this.GeneralPnl.Name = "GeneralPnl";
            this.GeneralPnl.Size = new System.Drawing.Size(451, 299);
            this.GeneralPnl.TabIndex = 26;
            // 
            // APISelector
            // 
            this.APISelector.BackColor = System.Drawing.Color.Transparent;
            this.APISelector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.APISelector.BorderRadius = 8;
            this.APISelector.BorderThickness = 2;
            this.APISelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.APISelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APISelector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.APISelector.FocusedColor = System.Drawing.Color.Red;
            this.APISelector.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.APISelector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.APISelector.ForeColor = System.Drawing.Color.White;
            this.APISelector.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.APISelector.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.APISelector.ItemHeight = 30;
            this.APISelector.Items.AddRange(new object[] {
            "WRD API",
            "Krnl API",
            "Oxygen U API"});
            this.APISelector.Location = new System.Drawing.Point(284, 14);
            this.APISelector.Name = "APISelector";
            this.APISelector.Size = new System.Drawing.Size(141, 36);
            this.APISelector.TabIndex = 30;
            this.APISelector.SelectedIndexChanged += new System.EventHandler(this.APISelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(406, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "    ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "API Selector";
            // 
            // AutoAttachSwitch
            // 
            this.AutoAttachSwitch.Animated = true;
            this.AutoAttachSwitch.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.AutoAttachSwitch.CheckedState.FillColor = System.Drawing.Color.Red;
            this.AutoAttachSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AutoAttachSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AutoAttachSwitch.Location = new System.Drawing.Point(386, 85);
            this.AutoAttachSwitch.Name = "AutoAttachSwitch";
            this.AutoAttachSwitch.Size = new System.Drawing.Size(35, 20);
            this.AutoAttachSwitch.TabIndex = 23;
            this.AutoAttachSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.AutoAttachSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.AutoAttachSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AutoAttachSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.AutoAttachSwitch.CheckedChanged += new System.EventHandler(this.AutoAttachSwitch_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Automatically attaches Atonix to ROBLOX";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Separator3.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator3.Location = new System.Drawing.Point(11, 120);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(414, 10);
            this.guna2Separator3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Auto Attach";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Select your API to attach and execute";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Separator4.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator4.Location = new System.Drawing.Point(11, 59);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(414, 10);
            this.guna2Separator4.TabIndex = 17;
            // 
            // APISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(451, 299);
            this.Controls.Add(this.GeneralPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APISettings";
            this.Text = "APISelector";
            this.Load += new System.EventHandler(this.APISettings_Load);
            this.GeneralPnl.ResumeLayout(false);
            this.GeneralPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel GeneralPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ToggleSwitch AutoAttachSwitch;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2ComboBox APISelector;
    }
}