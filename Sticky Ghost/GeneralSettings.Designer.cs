namespace Sticky_Ghost
{
    partial class GeneralSettings
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralSettings));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnKeepIntouch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnOpenSource = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnChangeLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSupport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.openSource1 = new Sticky_Ghost.OpenSource();
            this.keepIntouch1 = new Sticky_Ghost.KeepIntouch();
            this.about1 = new Sticky_Ghost.About();
            this.changeLog1 = new Sticky_Ghost.ChangeLog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.support1 = new Sticky_Ghost.Support();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.ButtonClose);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox7);
            this.animator1.SetDecoration(this.panel3, AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 32);
            this.panel3.TabIndex = 105;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // ButtonClose
            // 
            this.ButtonClose.ActiveBorderThickness = 1;
            this.ButtonClose.ActiveCornerRadius = 11;
            this.ButtonClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.ButtonClose.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.ButtonClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ButtonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClose.BackgroundImage")));
            this.ButtonClose.ButtonText = "";
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.ButtonClose, AnimatorNS.DecorationType.None);
            this.ButtonClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonClose.IdleBorderThickness = 1;
            this.ButtonClose.IdleCornerRadius = 11;
            this.ButtonClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ButtonClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ButtonClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ButtonClose.Location = new System.Drawing.Point(758, 5);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(13, 23);
            this.ButtonClose.TabIndex = 82;
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.animator1.SetDecoration(this.pictureBox3, AnimatorNS.DecorationType.None);
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(779, 2);
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.animator1.SetDecoration(this.pictureBox7, AnimatorNS.DecorationType.None);
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox7.Location = new System.Drawing.Point(0, 30);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(779, 2);
            this.pictureBox7.TabIndex = 55;
            this.pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.animator1.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(249, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 501);
            this.panel2.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.BtnKeepIntouch);
            this.panel1.Controls.Add(this.BtnOpenSource);
            this.panel1.Controls.Add(this.BtnChangeLog);
            this.panel1.Controls.Add(this.BtnSupport);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.animator1.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 501);
            this.panel1.TabIndex = 106;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.LightGray;
            this.animator1.SetDecoration(this.indicator, AnimatorNS.DecorationType.None);
            this.indicator.Location = new System.Drawing.Point(244, 114);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(3, 40);
            this.indicator.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Others";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Help and More";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.animator1.SetDecoration(this.panel5, AnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(0, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 2);
            this.panel5.TabIndex = 109;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbout.BorderRadius = 0;
            this.BtnAbout.ButtonText = "    About Sticky Ghost";
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.BtnAbout, AnimatorNS.DecorationType.None);
            this.BtnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAbout.Iconimage = global::Sticky_Ghost.Properties.Resources.About_48px;
            this.BtnAbout.Iconimage_right = null;
            this.BtnAbout.Iconimage_right_Selected = null;
            this.BtnAbout.Iconimage_Selected = null;
            this.BtnAbout.IconMarginLeft = 20;
            this.BtnAbout.IconMarginRight = 0;
            this.BtnAbout.IconRightVisible = true;
            this.BtnAbout.IconRightZoom = 0D;
            this.BtnAbout.IconVisible = true;
            this.BtnAbout.IconZoom = 44D;
            this.BtnAbout.IsTab = true;
            this.BtnAbout.Location = new System.Drawing.Point(-1, 209);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAbout.selected = false;
            this.BtnAbout.Size = new System.Drawing.Size(251, 40);
            this.BtnAbout.TabIndex = 108;
            this.BtnAbout.Text = "    About Sticky Ghost";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Textcolor = System.Drawing.Color.Gray;
            this.BtnAbout.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnKeepIntouch
            // 
            this.BtnKeepIntouch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnKeepIntouch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnKeepIntouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKeepIntouch.BorderRadius = 0;
            this.BtnKeepIntouch.ButtonText = "   Keep Intouch";
            this.BtnKeepIntouch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.BtnKeepIntouch, AnimatorNS.DecorationType.None);
            this.BtnKeepIntouch.DisabledColor = System.Drawing.Color.Gray;
            this.BtnKeepIntouch.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnKeepIntouch.Iconimage = global::Sticky_Ghost.Properties.Resources.Heart_with_Pulse_48px;
            this.BtnKeepIntouch.Iconimage_right = null;
            this.BtnKeepIntouch.Iconimage_right_Selected = null;
            this.BtnKeepIntouch.Iconimage_Selected = null;
            this.BtnKeepIntouch.IconMarginLeft = 20;
            this.BtnKeepIntouch.IconMarginRight = 0;
            this.BtnKeepIntouch.IconRightVisible = true;
            this.BtnKeepIntouch.IconRightZoom = 0D;
            this.BtnKeepIntouch.IconVisible = true;
            this.BtnKeepIntouch.IconZoom = 43D;
            this.BtnKeepIntouch.IsTab = true;
            this.BtnKeepIntouch.Location = new System.Drawing.Point(0, 365);
            this.BtnKeepIntouch.Name = "BtnKeepIntouch";
            this.BtnKeepIntouch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnKeepIntouch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnKeepIntouch.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnKeepIntouch.selected = false;
            this.BtnKeepIntouch.Size = new System.Drawing.Size(250, 40);
            this.BtnKeepIntouch.TabIndex = 91;
            this.BtnKeepIntouch.Text = "   Keep Intouch";
            this.BtnKeepIntouch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeepIntouch.Textcolor = System.Drawing.Color.Gray;
            this.BtnKeepIntouch.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeepIntouch.Click += new System.EventHandler(this.BtnKeepIntouch_Click);
            // 
            // BtnOpenSource
            // 
            this.BtnOpenSource.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnOpenSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnOpenSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOpenSource.BorderRadius = 0;
            this.BtnOpenSource.ButtonText = "   Open Source";
            this.BtnOpenSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.BtnOpenSource, AnimatorNS.DecorationType.None);
            this.BtnOpenSource.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOpenSource.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOpenSource.Iconimage = global::Sticky_Ghost.Properties.Resources.Repository_48px;
            this.BtnOpenSource.Iconimage_right = null;
            this.BtnOpenSource.Iconimage_right_Selected = null;
            this.BtnOpenSource.Iconimage_Selected = null;
            this.BtnOpenSource.IconMarginLeft = 20;
            this.BtnOpenSource.IconMarginRight = 0;
            this.BtnOpenSource.IconRightVisible = true;
            this.BtnOpenSource.IconRightZoom = 0D;
            this.BtnOpenSource.IconVisible = true;
            this.BtnOpenSource.IconZoom = 43D;
            this.BtnOpenSource.IsTab = true;
            this.BtnOpenSource.Location = new System.Drawing.Point(-1, 318);
            this.BtnOpenSource.Name = "BtnOpenSource";
            this.BtnOpenSource.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnOpenSource.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnOpenSource.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOpenSource.selected = false;
            this.BtnOpenSource.Size = new System.Drawing.Size(251, 40);
            this.BtnOpenSource.TabIndex = 90;
            this.BtnOpenSource.Text = "   Open Source";
            this.BtnOpenSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenSource.Textcolor = System.Drawing.Color.Gray;
            this.BtnOpenSource.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenSource.Click += new System.EventHandler(this.BtnOpenSource_Click);
            // 
            // BtnChangeLog
            // 
            this.BtnChangeLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnChangeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnChangeLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChangeLog.BorderRadius = 0;
            this.BtnChangeLog.ButtonText = "    Change Log";
            this.BtnChangeLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.BtnChangeLog, AnimatorNS.DecorationType.None);
            this.BtnChangeLog.DisabledColor = System.Drawing.Color.Gray;
            this.BtnChangeLog.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnChangeLog.Iconimage = global::Sticky_Ghost.Properties.Resources.Advertising_48px1;
            this.BtnChangeLog.Iconimage_right = null;
            this.BtnChangeLog.Iconimage_right_Selected = null;
            this.BtnChangeLog.Iconimage_Selected = null;
            this.BtnChangeLog.IconMarginLeft = 20;
            this.BtnChangeLog.IconMarginRight = 0;
            this.BtnChangeLog.IconRightVisible = true;
            this.BtnChangeLog.IconRightZoom = 0D;
            this.BtnChangeLog.IconVisible = true;
            this.BtnChangeLog.IconZoom = 43D;
            this.BtnChangeLog.IsTab = true;
            this.BtnChangeLog.Location = new System.Drawing.Point(0, 161);
            this.BtnChangeLog.Name = "BtnChangeLog";
            this.BtnChangeLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnChangeLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnChangeLog.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnChangeLog.selected = false;
            this.BtnChangeLog.Size = new System.Drawing.Size(250, 40);
            this.BtnChangeLog.TabIndex = 88;
            this.BtnChangeLog.Text = "    Change Log";
            this.BtnChangeLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChangeLog.Textcolor = System.Drawing.Color.Gray;
            this.BtnChangeLog.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeLog.Click += new System.EventHandler(this.BtnChangeLog_Click);
            // 
            // BtnSupport
            // 
            this.BtnSupport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSupport.BorderRadius = 0;
            this.BtnSupport.ButtonText = "    Support";
            this.BtnSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.BtnSupport, AnimatorNS.DecorationType.None);
            this.BtnSupport.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSupport.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSupport.Iconimage = global::Sticky_Ghost.Properties.Resources.Support_48px;
            this.BtnSupport.Iconimage_right = null;
            this.BtnSupport.Iconimage_right_Selected = null;
            this.BtnSupport.Iconimage_Selected = null;
            this.BtnSupport.IconMarginLeft = 20;
            this.BtnSupport.IconMarginRight = 0;
            this.BtnSupport.IconRightVisible = true;
            this.BtnSupport.IconRightZoom = 0D;
            this.BtnSupport.IconVisible = true;
            this.BtnSupport.IconZoom = 43D;
            this.BtnSupport.IsTab = true;
            this.BtnSupport.Location = new System.Drawing.Point(0, 115);
            this.BtnSupport.Name = "BtnSupport";
            this.BtnSupport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnSupport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnSupport.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSupport.selected = true;
            this.BtnSupport.Size = new System.Drawing.Size(250, 40);
            this.BtnSupport.TabIndex = 85;
            this.BtnSupport.Text = "    Support";
            this.BtnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupport.Textcolor = System.Drawing.Color.Gray;
            this.BtnSupport.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupport.Click += new System.EventHandler(this.BtnSupport_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.animator1.SetDecoration(this.panel4, AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(23, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 80;
            this.label1.Text = "Sticky Ghost";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.support1);
            this.panelMain.Controls.Add(this.openSource1);
            this.panelMain.Controls.Add(this.keepIntouch1);
            this.panelMain.Controls.Add(this.about1);
            this.panelMain.Controls.Add(this.changeLog1);
            this.animator1.SetDecoration(this.panelMain, AnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(252, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(529, 501);
            this.panelMain.TabIndex = 108;
            // 
            // openSource1
            // 
            this.openSource1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.animator1.SetDecoration(this.openSource1, AnimatorNS.DecorationType.None);
            this.openSource1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openSource1.Location = new System.Drawing.Point(0, 0);
            this.openSource1.Name = "openSource1";
            this.openSource1.Size = new System.Drawing.Size(529, 501);
            this.openSource1.TabIndex = 3;
            // 
            // keepIntouch1
            // 
            this.keepIntouch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.animator1.SetDecoration(this.keepIntouch1, AnimatorNS.DecorationType.None);
            this.keepIntouch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keepIntouch1.Location = new System.Drawing.Point(0, 0);
            this.keepIntouch1.Name = "keepIntouch1";
            this.keepIntouch1.Size = new System.Drawing.Size(529, 501);
            this.keepIntouch1.TabIndex = 2;
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.animator1.SetDecoration(this.about1, AnimatorNS.DecorationType.None);
            this.about1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about1.Location = new System.Drawing.Point(0, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(529, 501);
            this.about1.TabIndex = 1;
            // 
            // changeLog1
            // 
            this.changeLog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.animator1.SetDecoration(this.changeLog1, AnimatorNS.DecorationType.None);
            this.changeLog1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeLog1.Location = new System.Drawing.Point(0, 0);
            this.changeLog1.Name = "changeLog1";
            this.changeLog1.Size = new System.Drawing.Size(529, 501);
            this.changeLog1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.animator1.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(781, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 533);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.animator1.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 533);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(781, 2);
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.animator1.SetDecoration(this.pictureBox4, AnimatorNS.DecorationType.None);
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 535);
            this.pictureBox4.TabIndex = 95;
            this.pictureBox4.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveBorderThickness = 1;
            this.BtnClose.ActiveCornerRadius = 11;
            this.BtnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.BtnClose.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.BtnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.ButtonText = "";
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.BtnClose, AnimatorNS.DecorationType.None);
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.IdleBorderThickness = 1;
            this.BtnClose.IdleCornerRadius = 11;
            this.BtnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BtnClose.Location = new System.Drawing.Point(760, 14);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 23);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.MaxAnimationTime = 700;
            // 
            // support1
            // 
            this.support1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.animator1.SetDecoration(this.support1, AnimatorNS.DecorationType.None);
            this.support1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.support1.Location = new System.Drawing.Point(0, 0);
            this.support1.Name = "support1";
            this.support1.Size = new System.Drawing.Size(529, 501);
            this.support1.TabIndex = 4;
            // 
            // GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(783, 535);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnClose);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Settings";
            this.Load += new System.EventHandler(this.GeneralSettings_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSupport;
        private Bunifu.Framework.UI.BunifuFlatButton BtnChangeLog;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOpenSource;
        private Bunifu.Framework.UI.BunifuFlatButton BtnKeepIntouch;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Panel panelMain;
        private About about1;
        private ChangeLog changeLog1;
        private KeepIntouch keepIntouch1;
        private OpenSource openSource1;
        private AnimatorNS.Animator animator1;
        private Support support1;
    }
}