namespace AlibabaDesktopApp.View
{
    partial class AdminView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sideBar = new System.Windows.Forms.Panel();
            this.profileBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.PictureBox();
            this.profileAvatar = new System.Windows.Forms.PictureBox();
            this.Animator = new System.Windows.Forms.Timer(this.components);
            this.Animator2 = new System.Windows.Forms.Timer(this.components);
            this.optionContainer = new System.Windows.Forms.Panel();
            this.rejectedRequestsBtn = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newRequestsBtn = new System.Windows.Forms.PictureBox();
            this.sendNotificationBtn = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeVendorBtn = new System.Windows.Forms.PictureBox();
            this.previousRequestsBtn = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seeAllVendorsBtn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.threeLiner = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileAvatar)).BeginInit();
            this.optionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedRequestsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRequestsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendNotificationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeVendorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousRequestsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeAllVendorsBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threeLiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sideBar.Controls.Add(this.profileBtn);
            this.sideBar.Controls.Add(this.label1);
            this.sideBar.Controls.Add(this.logoutBtn);
            this.sideBar.Controls.Add(this.profileAvatar);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 100);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(151, 435);
            this.sideBar.TabIndex = 1;
            // 
            // profileBtn
            // 
            this.profileBtn.AllowTransparency = true;
            this.profileBtn.AnimationInterval = 1;
            this.profileBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileBtn.BGColor = "#508ef5";
            this.profileBtn.Corners = 1F;
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.profileBtn.DoubleRipple = false;
            this.profileBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.profileBtn.FontColor = "#ffffff";
            this.profileBtn.ForeColor = System.Drawing.Color.Black;
            this.profileBtn.Location = new System.Drawing.Point(-2, 172);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.profileBtn.RippleOpacity = 25;
            this.profileBtn.Size = new System.Drawing.Size(155, 42);
            this.profileBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.profileBtn.TabIndex = 44;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logout";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Image = global::AlibabaDesktopApp.Properties.Resources.on_off_button;
            this.logoutBtn.Location = new System.Drawing.Point(52, 363);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(34, 33);
            this.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profileAvatar
            // 
            this.profileAvatar.Image = global::AlibabaDesktopApp.Properties.Resources.profile;
            this.profileAvatar.Location = new System.Drawing.Point(20, 23);
            this.profileAvatar.Name = "profileAvatar";
            this.profileAvatar.Size = new System.Drawing.Size(100, 95);
            this.profileAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileAvatar.TabIndex = 1;
            this.profileAvatar.TabStop = false;
            // 
            // Animator
            // 
            this.Animator.Interval = 10;
            this.Animator.Tick += new System.EventHandler(this.Animator_Tick);
            // 
            // Animator2
            // 
            this.Animator2.Interval = 10;
            this.Animator2.Tick += new System.EventHandler(this.Animator2_Tick);
            // 
            // optionContainer
            // 
            this.optionContainer.Controls.Add(this.rejectedRequestsBtn);
            this.optionContainer.Controls.Add(this.label7);
            this.optionContainer.Controls.Add(this.newRequestsBtn);
            this.optionContainer.Controls.Add(this.sendNotificationBtn);
            this.optionContainer.Controls.Add(this.label5);
            this.optionContainer.Controls.Add(this.label2);
            this.optionContainer.Controls.Add(this.removeVendorBtn);
            this.optionContainer.Controls.Add(this.previousRequestsBtn);
            this.optionContainer.Controls.Add(this.label6);
            this.optionContainer.Controls.Add(this.label3);
            this.optionContainer.Controls.Add(this.seeAllVendorsBtn);
            this.optionContainer.Controls.Add(this.label4);
            this.optionContainer.Location = new System.Drawing.Point(238, 150);
            this.optionContainer.Name = "optionContainer";
            this.optionContainer.Size = new System.Drawing.Size(565, 346);
            this.optionContainer.TabIndex = 15;
            // 
            // rejectedRequestsBtn
            // 
            this.rejectedRequestsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectedRequestsBtn.Image = global::AlibabaDesktopApp.Properties.Resources.rejected;
            this.rejectedRequestsBtn.Location = new System.Drawing.Point(421, 8);
            this.rejectedRequestsBtn.Name = "rejectedRequestsBtn";
            this.rejectedRequestsBtn.Size = new System.Drawing.Size(132, 127);
            this.rejectedRequestsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rejectedRequestsBtn.TabIndex = 7;
            this.rejectedRequestsBtn.TabStop = false;
            this.rejectedRequestsBtn.Click += new System.EventHandler(this.rejectedRequestsBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(435, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Notify Vendor";
            // 
            // newRequestsBtn
            // 
            this.newRequestsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRequestsBtn.Image = global::AlibabaDesktopApp.Properties.Resources.new_message;
            this.newRequestsBtn.Location = new System.Drawing.Point(8, 8);
            this.newRequestsBtn.Name = "newRequestsBtn";
            this.newRequestsBtn.Size = new System.Drawing.Size(132, 127);
            this.newRequestsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newRequestsBtn.TabIndex = 2;
            this.newRequestsBtn.TabStop = false;
            this.newRequestsBtn.Click += new System.EventHandler(this.newRequestsBtn_Click);
            // 
            // sendNotificationBtn
            // 
            this.sendNotificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendNotificationBtn.Image = global::AlibabaDesktopApp.Properties.Resources.email;
            this.sendNotificationBtn.Location = new System.Drawing.Point(421, 188);
            this.sendNotificationBtn.Name = "sendNotificationBtn";
            this.sendNotificationBtn.Size = new System.Drawing.Size(132, 127);
            this.sendNotificationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendNotificationBtn.TabIndex = 13;
            this.sendNotificationBtn.TabStop = false;
            this.sendNotificationBtn.Click += new System.EventHandler(this.sendNotificationBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(223, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remove Vendor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Requests";
            // 
            // removeVendorBtn
            // 
            this.removeVendorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeVendorBtn.Image = global::AlibabaDesktopApp.Properties.Resources.add_to_the_basket;
            this.removeVendorBtn.Location = new System.Drawing.Point(218, 188);
            this.removeVendorBtn.Name = "removeVendorBtn";
            this.removeVendorBtn.Size = new System.Drawing.Size(132, 127);
            this.removeVendorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeVendorBtn.TabIndex = 11;
            this.removeVendorBtn.TabStop = false;
            this.removeVendorBtn.Click += new System.EventHandler(this.removeVendorBtn_Click);
            // 
            // previousRequestsBtn
            // 
            this.previousRequestsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousRequestsBtn.Image = global::AlibabaDesktopApp.Properties.Resources.new_email_notification;
            this.previousRequestsBtn.Location = new System.Drawing.Point(218, 8);
            this.previousRequestsBtn.Name = "previousRequestsBtn";
            this.previousRequestsBtn.Size = new System.Drawing.Size(132, 127);
            this.previousRequestsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previousRequestsBtn.TabIndex = 5;
            this.previousRequestsBtn.TabStop = false;
            this.previousRequestsBtn.Click += new System.EventHandler(this.previousRequestsBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "See All Vendors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(203, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Approved Requests";
            // 
            // seeAllVendorsBtn
            // 
            this.seeAllVendorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeAllVendorsBtn.Image = global::AlibabaDesktopApp.Properties.Resources.binoculars;
            this.seeAllVendorsBtn.Location = new System.Drawing.Point(14, 188);
            this.seeAllVendorsBtn.Name = "seeAllVendorsBtn";
            this.seeAllVendorsBtn.Size = new System.Drawing.Size(132, 127);
            this.seeAllVendorsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seeAllVendorsBtn.TabIndex = 9;
            this.seeAllVendorsBtn.TabStop = false;
            this.seeAllVendorsBtn.Click += new System.EventHandler(this.seeAllVendorsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(417, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rejected Requests";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AlibabaDesktopApp.Properties.Resources.background3;
            this.panel1.Controls.Add(this.threeLiner);
            this.panel1.Controls.Add(this.titleBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 100);
            this.panel1.TabIndex = 0;
            // 
            // threeLiner
            // 
            this.threeLiner.BackgroundImage = global::AlibabaDesktopApp.Properties.Resources.background3;
            this.threeLiner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeLiner.Image = global::AlibabaDesktopApp.Properties.Resources.menu;
            this.threeLiner.Location = new System.Drawing.Point(20, 37);
            this.threeLiner.Name = "threeLiner";
            this.threeLiner.Size = new System.Drawing.Size(56, 34);
            this.threeLiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threeLiner.TabIndex = 0;
            this.threeLiner.TabStop = false;
            this.threeLiner.Click += new System.EventHandler(this.threeLiner_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackgroundImage = global::AlibabaDesktopApp.Properties.Resources.background3;
            this.titleBar.Image = global::AlibabaDesktopApp.Properties.Resources.Amazon_logo;
            this.titleBar.Location = new System.Drawing.Point(84, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(784, 100);
            this.titleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleBar.TabIndex = 1;
            this.titleBar.TabStop = false;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionContainer);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.Name = "AdminView";
            this.Size = new System.Drawing.Size(869, 535);
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileAvatar)).EndInit();
            this.optionContainer.ResumeLayout(false);
            this.optionContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedRequestsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRequestsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendNotificationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeVendorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousRequestsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeAllVendorsBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.threeLiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox threeLiner;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.PictureBox titleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoutBtn;
        private System.Windows.Forms.PictureBox profileAvatar;
        private System.Windows.Forms.Timer Animator;
        private System.Windows.Forms.Timer Animator2;
        private System.Windows.Forms.Panel optionContainer;
        private System.Windows.Forms.PictureBox rejectedRequestsBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox newRequestsBtn;
        private System.Windows.Forms.PictureBox sendNotificationBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox removeVendorBtn;
        private System.Windows.Forms.PictureBox previousRequestsBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox seeAllVendorsBtn;
        private System.Windows.Forms.Label label4;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton profileBtn;
    }
}
