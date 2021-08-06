namespace ChatApp
{
    partial class Form1
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendBtn = new System.Windows.Forms.PictureBox();
            this.recordBtn = new System.Windows.Forms.PictureBox();
            this.attachBtn = new System.Windows.Forms.PictureBox();
            this.emojiBtn = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.PictureBox();
            this.WidgetHolder = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.moreOptionsBtn = new System.Windows.Forms.PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emojiBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            this.WidgetHolder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreOptionsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 18;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(139, 26);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Type Message";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(381, 44);
            this.guna2TextBox2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.sendBtn);
            this.panel2.Controls.Add(this.recordBtn);
            this.panel2.Controls.Add(this.attachBtn);
            this.panel2.Controls.Add(this.guna2TextBox2);
            this.panel2.Controls.Add(this.emojiBtn);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(355, 492);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 85);
            this.panel2.TabIndex = 7;
            // 
            // sendBtn
            // 
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.sendBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sendBtn.Image = global::ChatApp.Properties.Resources.send;
            this.sendBtn.Location = new System.Drawing.Point(527, 26);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(60, 44);
            this.sendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendBtn.TabIndex = 11;
            this.sendBtn.TabStop = false;
            // 
            // recordBtn
            // 
            this.recordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.recordBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.recordBtn.Image = global::ChatApp.Properties.Resources.record;
            this.recordBtn.Location = new System.Drawing.Point(591, 26);
            this.recordBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(60, 44);
            this.recordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recordBtn.TabIndex = 10;
            this.recordBtn.TabStop = false;
            // 
            // attachBtn
            // 
            this.attachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.attachBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.attachBtn.Image = global::ChatApp.Properties.Resources.attachment;
            this.attachBtn.Location = new System.Drawing.Point(75, 26);
            this.attachBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(60, 44);
            this.attachBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attachBtn.TabIndex = 9;
            this.attachBtn.TabStop = false;
            // 
            // emojiBtn
            // 
            this.emojiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.emojiBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.emojiBtn.Image = global::ChatApp.Properties.Resources.in_love_127px;
            this.emojiBtn.Location = new System.Drawing.Point(8, 26);
            this.emojiBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emojiBtn.Name = "emojiBtn";
            this.emojiBtn.Size = new System.Drawing.Size(60, 44);
            this.emojiBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emojiBtn.TabIndex = 8;
            this.emojiBtn.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.exitbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.exitbtn.Image = global::ChatApp.Properties.Resources.macos_close_96px;
            this.exitbtn.Location = new System.Drawing.Point(917, 15);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(68, 58);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbtn.TabIndex = 1;
            this.exitbtn.TabStop = false;
            this.exitbtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WidgetHolder
            // 
            this.WidgetHolder.AutoScroll = true;
            this.WidgetHolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WidgetHolder.BackgroundImage")));
            this.WidgetHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WidgetHolder.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this.WidgetHolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.WidgetHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.WidgetHolder.GradientBottomLeft = System.Drawing.Color.MediumSpringGreen;
            this.WidgetHolder.GradientBottomRight = System.Drawing.Color.Lime;
            this.WidgetHolder.GradientTopLeft = System.Drawing.Color.Maroon;
            this.WidgetHolder.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.WidgetHolder.Location = new System.Drawing.Point(0, 0);
            this.WidgetHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidgetHolder.Name = "WidgetHolder";
            this.WidgetHolder.Quality = 10;
            this.WidgetHolder.Size = new System.Drawing.Size(355, 577);
            this.WidgetHolder.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.moreOptionsBtn);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 123);
            this.panel1.TabIndex = 3;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(101, 68);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search Contact";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(233, 44);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = global::ChatApp.Properties.Resources.avatar;
            this.pictureBox5.Location = new System.Drawing.Point(4, 15);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 97);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.pictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::ChatApp.Properties.Resources.status;
            this.pictureBox4.Location = new System.Drawing.Point(101, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.pictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::ChatApp.Properties.Resources.new_chat;
            this.pictureBox3.Location = new System.Drawing.Point(193, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // moreOptionsBtn
            // 
            this.moreOptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.moreOptionsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.moreOptionsBtn.Image = global::ChatApp.Properties.Resources.three_liner;
            this.moreOptionsBtn.Location = new System.Drawing.Point(283, 15);
            this.moreOptionsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moreOptionsBtn.Name = "moreOptionsBtn";
            this.moreOptionsBtn.Size = new System.Drawing.Size(52, 38);
            this.moreOptionsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moreOptionsBtn.TabIndex = 2;
            this.moreOptionsBtn.TabStop = false;
            this.moreOptionsBtn.Click += new System.EventHandler(this.moreOptionsBtn_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderRadius = 18;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(363, 98);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Type Message";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(381, 44);
            this.guna2TextBox3.TabIndex = 8;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderRadius = 18;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Location = new System.Drawing.Point(627, 165);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "Type Message";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(381, 44);
            this.guna2TextBox4.TabIndex = 9;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderRadius = 18;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Location = new System.Drawing.Point(363, 234);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "Type Message";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(381, 44);
            this.guna2TextBox5.TabIndex = 10;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderRadius = 18;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.FocusedState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.HoverState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Location = new System.Drawing.Point(363, 307);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "Type Message";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.ShadowDecoration.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Size = new System.Drawing.Size(381, 44);
            this.guna2TextBox6.TabIndex = 11;
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.BorderRadius = 18;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.guna2TextBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox7.DefaultText = "";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.Parent = this.guna2TextBox7;
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.FocusedState.Parent = this.guna2TextBox7;
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox7.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.HoverState.Parent = this.guna2TextBox7;
            this.guna2TextBox7.Location = new System.Drawing.Point(627, 372);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "Type Message";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.ShadowDecoration.Parent = this.guna2TextBox7;
            this.guna2TextBox7.Size = new System.Drawing.Size(381, 44);
            this.guna2TextBox7.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1021, 577);
            this.Controls.Add(this.guna2TextBox7);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.WidgetHolder);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emojiBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            this.WidgetHolder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreOptionsBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel WidgetHolder;
        private System.Windows.Forms.PictureBox exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox moreOptionsBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.PictureBox emojiBtn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.PictureBox attachBtn;
        private System.Windows.Forms.PictureBox sendBtn;
        private System.Windows.Forms.PictureBox recordBtn;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
    }
}

