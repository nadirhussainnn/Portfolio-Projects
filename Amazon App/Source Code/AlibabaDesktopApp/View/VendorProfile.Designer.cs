namespace AlibabaDesktopApp.View
{
    partial class VendorProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            this.browseBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.deleteAccountBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.updateBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.deleteAccountBtn);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(19, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 288);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryComboBox.Enabled = false;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Books",
            "Cameras",
            "Laptops",
            "Mobiles"});
            this.categoryComboBox.Location = new System.Drawing.Point(131, 178);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryComboBox.Size = new System.Drawing.Size(366, 25);
            this.categoryComboBox.Sorted = true;
            this.categoryComboBox.TabIndex = 31;
            this.categoryComboBox.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "Want to Sell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Change Pic";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Black;
            this.passwordBox.Location = new System.Drawing.Point(131, 142);
            this.passwordBox.MaxLength = 40;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(366, 24);
            this.passwordBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.Black;
            this.emailBox.Location = new System.Drawing.Point(131, 107);
            this.emailBox.MaxLength = 40;
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(366, 31);
            this.emailBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "E-Mail";
            // 
            // lastNameBox
            // 
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameBox.Location = new System.Drawing.Point(131, 65);
            this.lastNameBox.MaxLength = 40;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(366, 24);
            this.lastNameBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameBox.Location = new System.Drawing.Point(131, 23);
            this.firstNameBox.MaxLength = 40;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(366, 24);
            this.firstNameBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(512, 3);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 13;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.AllowTransparency = true;
            this.browseBtn.AnimationInterval = 1;
            this.browseBtn.BackColor = System.Drawing.Color.Transparent;
            this.browseBtn.BGColor = "#508ef5";
            this.browseBtn.Corners = 1F;
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.browseBtn.DoubleRipple = false;
            this.browseBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.browseBtn.FontColor = "#ffffff";
            this.browseBtn.ForeColor = System.Drawing.Color.Black;
            this.browseBtn.Location = new System.Drawing.Point(131, 211);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.browseBtn.RippleOpacity = 25;
            this.browseBtn.Size = new System.Drawing.Size(366, 29);
            this.browseBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.browseBtn.TabIndex = 77;
            this.browseBtn.Text = "Browse";
            this.browseBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click_1);
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.AllowTransparency = true;
            this.deleteAccountBtn.AnimationInterval = 1;
            this.deleteAccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteAccountBtn.BGColor = "#508ef5";
            this.deleteAccountBtn.Corners = 1F;
            this.deleteAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAccountBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.deleteAccountBtn.DoubleRipple = false;
            this.deleteAccountBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.deleteAccountBtn.FontColor = "#ffffff";
            this.deleteAccountBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteAccountBtn.Location = new System.Drawing.Point(131, 249);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.deleteAccountBtn.RippleOpacity = 25;
            this.deleteAccountBtn.Size = new System.Drawing.Size(157, 29);
            this.deleteAccountBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.deleteAccountBtn.TabIndex = 78;
            this.deleteAccountBtn.Text = "Delete Account";
            this.deleteAccountBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.AllowTransparency = true;
            this.updateBtn.AnimationInterval = 1;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BGColor = "#508ef5";
            this.updateBtn.Corners = 1F;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.updateBtn.DoubleRipple = false;
            this.updateBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.updateBtn.FontColor = "#ffffff";
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(340, 249);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.updateBtn.RippleOpacity = 25;
            this.updateBtn.Size = new System.Drawing.Size(157, 29);
            this.updateBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.updateBtn.TabIndex = 79;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // VendorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backToHomeBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "VendorProfile";
            this.Size = new System.Drawing.Size(565, 346);
            this.Load += new System.EventHandler(this.VendorProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backToHomeBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton browseBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton deleteAccountBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton updateBtn;
    }
}
