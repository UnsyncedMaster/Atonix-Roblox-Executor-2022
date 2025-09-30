namespace Atonix.Windows
{
    partial class Monaco
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
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label9 = new System.Windows.Forms.Label();
            this.ScrollBarArrowsSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SmoothScrollingSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label6 = new System.Windows.Forms.Label();
            this.MiniMapSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
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
            this.GeneralPnl.Controls.Add(this.RefreshBtn);
            this.GeneralPnl.Controls.Add(this.label4);
            this.GeneralPnl.Controls.Add(this.guna2Separator2);
            this.GeneralPnl.Controls.Add(this.label9);
            this.GeneralPnl.Controls.Add(this.ScrollBarArrowsSwitch);
            this.GeneralPnl.Controls.Add(this.label2);
            this.GeneralPnl.Controls.Add(this.guna2Separator1);
            this.GeneralPnl.Controls.Add(this.label3);
            this.GeneralPnl.Controls.Add(this.label1);
            this.GeneralPnl.Controls.Add(this.label8);
            this.GeneralPnl.Controls.Add(this.SmoothScrollingSwitch);
            this.GeneralPnl.Controls.Add(this.label5);
            this.GeneralPnl.Controls.Add(this.guna2Separator3);
            this.GeneralPnl.Controls.Add(this.label6);
            this.GeneralPnl.Controls.Add(this.MiniMapSwitch);
            this.GeneralPnl.Controls.Add(this.label7);
            this.GeneralPnl.Controls.Add(this.guna2Separator4);
            this.GeneralPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralPnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GeneralPnl.Location = new System.Drawing.Point(0, 0);
            this.GeneralPnl.Name = "GeneralPnl";
            this.GeneralPnl.Size = new System.Drawing.Size(451, 299);
            this.GeneralPnl.TabIndex = 26;
            this.GeneralPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.GeneralPnl_Paint);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Animated = true;
            this.RefreshBtn.BorderRadius = 4;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.RefreshBtn.Location = new System.Drawing.Point(322, 196);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(101, 42);
            this.RefreshBtn.TabIndex = 41;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Reloads the monaco incase of bugs or changes";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Separator2.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator2.Location = new System.Drawing.Point(12, 242);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(414, 10);
            this.guna2Separator2.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Refresh Monaco";
            // 
            // ScrollBarArrowsSwitch
            // 
            this.ScrollBarArrowsSwitch.Animated = true;
            this.ScrollBarArrowsSwitch.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.ScrollBarArrowsSwitch.CheckedState.FillColor = System.Drawing.Color.Red;
            this.ScrollBarArrowsSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ScrollBarArrowsSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ScrollBarArrowsSwitch.Location = new System.Drawing.Point(386, 146);
            this.ScrollBarArrowsSwitch.Name = "ScrollBarArrowsSwitch";
            this.ScrollBarArrowsSwitch.Size = new System.Drawing.Size(35, 20);
            this.ScrollBarArrowsSwitch.TabIndex = 29;
            this.ScrollBarArrowsSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ScrollBarArrowsSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ScrollBarArrowsSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ScrollBarArrowsSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ScrollBarArrowsSwitch.CheckedChanged += new System.EventHandler(this.ScrollBarArrowsSwitch_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(8, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enables arrows for the scroll bar";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Separator1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator1.Location = new System.Drawing.Point(11, 181);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(414, 10);
            this.guna2Separator1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Scroll Bar Arrows";
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
            this.label8.Size = new System.Drawing.Size(303, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mini Map";
            // 
            // SmoothScrollingSwitch
            // 
            this.SmoothScrollingSwitch.Animated = true;
            this.SmoothScrollingSwitch.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.SmoothScrollingSwitch.CheckedState.FillColor = System.Drawing.Color.Red;
            this.SmoothScrollingSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SmoothScrollingSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SmoothScrollingSwitch.Location = new System.Drawing.Point(386, 85);
            this.SmoothScrollingSwitch.Name = "SmoothScrollingSwitch";
            this.SmoothScrollingSwitch.Size = new System.Drawing.Size(35, 20);
            this.SmoothScrollingSwitch.TabIndex = 23;
            this.SmoothScrollingSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SmoothScrollingSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SmoothScrollingSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SmoothScrollingSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SmoothScrollingSwitch.CheckedChanged += new System.EventHandler(this.SmoothScrollingSwitch_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Makes scrolling feel smooth";
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
            this.label6.Size = new System.Drawing.Size(311, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Smooth Scrolling";
            // 
            // MiniMapSwitch
            // 
            this.MiniMapSwitch.Animated = true;
            this.MiniMapSwitch.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.MiniMapSwitch.CheckedState.FillColor = System.Drawing.Color.Red;
            this.MiniMapSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.MiniMapSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.MiniMapSwitch.Location = new System.Drawing.Point(386, 24);
            this.MiniMapSwitch.Name = "MiniMapSwitch";
            this.MiniMapSwitch.Size = new System.Drawing.Size(35, 20);
            this.MiniMapSwitch.TabIndex = 19;
            this.MiniMapSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MiniMapSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MiniMapSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.MiniMapSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.MiniMapSwitch.CheckedChanged += new System.EventHandler(this.MiniMapSwitch_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Shows a code Mini-Map in the editor";
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
            // Monaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(451, 299);
            this.Controls.Add(this.GeneralPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monaco";
            this.Text = "Monaco";
            this.Load += new System.EventHandler(this.Monaco_Load);
            this.GeneralPnl.ResumeLayout(false);
            this.GeneralPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel GeneralPnl;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SmoothScrollingSwitch;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch MiniMapSwitch;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ScrollBarArrowsSwitch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label9;
    }
}