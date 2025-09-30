namespace Atonix
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.IconPb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ScriptBox = new System.Windows.Forms.ListBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MonacoEditor = new System.Windows.Forms.WebBrowser();
            this.Status = new System.Windows.Forms.Timer(this.components);
            this.AutoAttach = new System.Windows.Forms.Timer(this.components);
            this.ExecuteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EraseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.OpenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ScriptHubBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AttachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl6 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.RandomUIbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Panel1.Controls.Add(this.IconPb);
            this.guna2Panel1.Controls.Add(this.StatusLbl);
            this.guna2Panel1.Controls.Add(this.MinimizeBtn);
            this.guna2Panel1.Controls.Add(this.CloseBtn);
            this.guna2Panel1.Controls.Add(this.MaximizeBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(764, 38);
            this.guna2Panel1.TabIndex = 1;
            // 
            // IconPb
            // 
            this.IconPb.BackColor = System.Drawing.Color.Transparent;
            this.IconPb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IconPb.Image = ((System.Drawing.Image)(resources.GetObject("IconPb.Image")));
            this.IconPb.ImageRotate = 0F;
            this.IconPb.Location = new System.Drawing.Point(5, 4);
            this.IconPb.Name = "IconPb";
            this.IconPb.Size = new System.Drawing.Size(30, 30);
            this.IconPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPb.TabIndex = 11;
            this.IconPb.TabStop = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.Location = new System.Drawing.Point(41, 5);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(165, 25);
            this.StatusLbl.TabIndex = 21;
            this.StatusLbl.Text = "Not Injected";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.Animated = true;
            this.MinimizeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeBtn.IconColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(641, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(41, 38);
            this.MinimizeBtn.TabIndex = 13;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.CustomClick = true;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(723, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(41, 38);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.Animated = true;
            this.MaximizeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MaximizeBtn.IconColor = System.Drawing.Color.White;
            this.MaximizeBtn.Location = new System.Drawing.Point(682, 0);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(41, 38);
            this.MaximizeBtn.TabIndex = 12;
            // 
            // ScriptBox
            // 
            this.ScriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.FormattingEnabled = true;
            this.ScriptBox.ItemHeight = 15;
            this.ScriptBox.Location = new System.Drawing.Point(566, 74);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Size = new System.Drawing.Size(193, 270);
            this.ScriptBox.TabIndex = 3;
            this.ScriptBox.SelectedIndexChanged += new System.EventHandler(this.ScriptBox_SelectedIndexChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MonacoEditor
            // 
            this.MonacoEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonacoEditor.Location = new System.Drawing.Point(6, 44);
            this.MonacoEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.MonacoEditor.Name = "MonacoEditor";
            this.MonacoEditor.Size = new System.Drawing.Size(554, 300);
            this.MonacoEditor.TabIndex = 18;
            this.MonacoEditor.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MonacoEditor_DocumentCompleted);
            // 
            // Status
            // 
            this.Status.Enabled = true;
            this.Status.Interval = 2000;
            this.Status.Tick += new System.EventHandler(this.Status_Tick);
            // 
            // AutoAttach
            // 
            this.AutoAttach.Enabled = true;
            this.AutoAttach.Interval = 6000;
            this.AutoAttach.Tick += new System.EventHandler(this.AutoAttach_Tick);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExecuteBtn.Animated = true;
            this.ExecuteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ExecuteBtn.BorderRadius = 4;
            this.ExecuteBtn.BorderThickness = 1;
            this.ExecuteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExecuteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExecuteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExecuteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExecuteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteBtn.ForeColor = System.Drawing.Color.White;
            this.ExecuteBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ExecuteBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.ExecuteBtn.Location = new System.Drawing.Point(6, 350);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(84, 33);
            this.ExecuteBtn.TabIndex = 11;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // EraseBtn
            // 
            this.EraseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EraseBtn.Animated = true;
            this.EraseBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.EraseBtn.BorderRadius = 4;
            this.EraseBtn.BorderThickness = 1;
            this.EraseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EraseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EraseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EraseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EraseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.EraseBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraseBtn.ForeColor = System.Drawing.Color.White;
            this.EraseBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.EraseBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.EraseBtn.Location = new System.Drawing.Point(96, 350);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(65, 33);
            this.EraseBtn.TabIndex = 12;
            this.EraseBtn.Text = "Erase";
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenBtn.Animated = true;
            this.OpenBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OpenBtn.BorderRadius = 4;
            this.OpenBtn.BorderThickness = 1;
            this.OpenBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OpenBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.OpenBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.OpenBtn.Location = new System.Drawing.Point(167, 350);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(68, 33);
            this.OpenBtn.TabIndex = 13;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveBtn.Animated = true;
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SaveBtn.BorderRadius = 4;
            this.SaveBtn.BorderThickness = 1;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.SaveBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.SaveBtn.Location = new System.Drawing.Point(241, 350);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(68, 33);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsBtn.Animated = true;
            this.SettingsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsBtn.BorderRadius = 4;
            this.SettingsBtn.BorderThickness = 1;
            this.SettingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.SettingsBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.SettingsBtn.Location = new System.Drawing.Point(315, 350);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(84, 33);
            this.SettingsBtn.TabIndex = 15;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ScriptHubBtn
            // 
            this.ScriptHubBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptHubBtn.Animated = true;
            this.ScriptHubBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ScriptHubBtn.BorderRadius = 4;
            this.ScriptHubBtn.BorderThickness = 1;
            this.ScriptHubBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ScriptHubBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ScriptHubBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ScriptHubBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ScriptHubBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ScriptHubBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHubBtn.ForeColor = System.Drawing.Color.White;
            this.ScriptHubBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ScriptHubBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.ScriptHubBtn.Location = new System.Drawing.Point(652, 350);
            this.ScriptHubBtn.Name = "ScriptHubBtn";
            this.ScriptHubBtn.Size = new System.Drawing.Size(107, 33);
            this.ScriptHubBtn.TabIndex = 17;
            this.ScriptHubBtn.Text = "Script Hub";
            this.ScriptHubBtn.Click += new System.EventHandler(this.ScriptHubBtn_Click);
            // 
            // AttachBtn
            // 
            this.AttachBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachBtn.Animated = true;
            this.AttachBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AttachBtn.BorderRadius = 4;
            this.AttachBtn.BorderThickness = 1;
            this.AttachBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AttachBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttachBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AttachBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AttachBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachBtn.ForeColor = System.Drawing.Color.White;
            this.AttachBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.AttachBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.AttachBtn.Location = new System.Drawing.Point(566, 350);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(80, 33);
            this.AttachBtn.TabIndex = 16;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // guna2DragControl6
            // 
            this.guna2DragControl6.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl6.DragStartTransparencyValue = 1D;
            this.guna2DragControl6.TargetControl = this.StatusLbl;
            this.guna2DragControl6.TransparentWhileDrag = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Animated = true;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SearchBox.BorderRadius = 4;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("SearchBox.IconLeft")));
            this.SearchBox.Location = new System.Drawing.Point(566, 44);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SearchBox.PlaceholderText = "";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(193, 24);
            this.SearchBox.TabIndex = 19;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.DragStartTransparencyValue = 1D;
            this.guna2DragControl2.TargetControl = this.IconPb;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // RandomUIbtn
            // 
            this.RandomUIbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomUIbtn.Animated = true;
            this.RandomUIbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RandomUIbtn.BorderRadius = 4;
            this.RandomUIbtn.BorderThickness = 1;
            this.RandomUIbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RandomUIbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RandomUIbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RandomUIbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RandomUIbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RandomUIbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomUIbtn.ForeColor = System.Drawing.Color.White;
            this.RandomUIbtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.RandomUIbtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.RandomUIbtn.Location = new System.Drawing.Point(405, 350);
            this.RandomUIbtn.Name = "RandomUIbtn";
            this.RandomUIbtn.Size = new System.Drawing.Size(108, 33);
            this.RandomUIbtn.TabIndex = 20;
            this.RandomUIbtn.Text = "Random UI";
            this.RandomUIbtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(764, 390);
            this.Controls.Add(this.RandomUIbtn);
            this.Controls.Add(this.EraseBtn);
            this.Controls.Add(this.AttachBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.MonacoEditor);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ScriptHubBtn);
            this.Controls.Add(this.SearchBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atonix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ListBox ScriptBox;
        private Guna.UI2.WinForms.Guna2PictureBox IconPb;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBtn;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBtn;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBtn;
        private System.Windows.Forms.WebBrowser MonacoEditor;
        private System.Windows.Forms.Timer Status;
        private System.Windows.Forms.Timer AutoAttach;
        private Guna.UI2.WinForms.Guna2Button ScriptHubBtn;
        private Guna.UI2.WinForms.Guna2Button AttachBtn;
        private Guna.UI2.WinForms.Guna2Button SettingsBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2Button OpenBtn;
        private Guna.UI2.WinForms.Guna2Button EraseBtn;
        private Guna.UI2.WinForms.Guna2Button ExecuteBtn;
        private System.Windows.Forms.Label StatusLbl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl6;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button RandomUIbtn;
    }
}

