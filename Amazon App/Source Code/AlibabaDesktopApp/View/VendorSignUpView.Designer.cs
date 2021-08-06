namespace AlibabaDesktopApp.View
{
    partial class VendorSignUpView
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
            this.PersonalInfoContainer = new System.Windows.Forms.GroupBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.browseBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.backBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.nextBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.PersonalInfoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalInfoContainer
            // 
            this.PersonalInfoContainer.Controls.Add(this.nextBtn);
            this.PersonalInfoContainer.Controls.Add(this.backBtn);
            this.PersonalInfoContainer.Controls.Add(this.browseBtn);
            this.PersonalInfoContainer.Controls.Add(this.categoryComboBox);
            this.PersonalInfoContainer.Controls.Add(this.label6);
            this.PersonalInfoContainer.Controls.Add(this.label5);
            this.PersonalInfoContainer.Controls.Add(this.passwordBox);
            this.PersonalInfoContainer.Controls.Add(this.label4);
            this.PersonalInfoContainer.Controls.Add(this.emailBox);
            this.PersonalInfoContainer.Controls.Add(this.label3);
            this.PersonalInfoContainer.Controls.Add(this.lastNameBox);
            this.PersonalInfoContainer.Controls.Add(this.label2);
            this.PersonalInfoContainer.Controls.Add(this.firstNameBox);
            this.PersonalInfoContainer.Controls.Add(this.label1);
            this.PersonalInfoContainer.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfoContainer.ForeColor = System.Drawing.Color.Blue;
            this.PersonalInfoContainer.Location = new System.Drawing.Point(19, 36);
            this.PersonalInfoContainer.Name = "PersonalInfoContainer";
            this.PersonalInfoContainer.Size = new System.Drawing.Size(527, 295);
            this.PersonalInfoContainer.TabIndex = 11;
            this.PersonalInfoContainer.TabStop = false;
            this.PersonalInfoContainer.Text = "Personal Info";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
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
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Profile Pic";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Black;
            this.passwordBox.Location = new System.Drawing.Point(131, 142);
            this.passwordBox.MaxLength = 40;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
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
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.Black;
            this.emailBox.Location = new System.Drawing.Point(131, 107);
            this.emailBox.MaxLength = 40;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(366, 24);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(200, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Apply To Sell";
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
            this.browseBtn.Location = new System.Drawing.Point(131, 212);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.browseBtn.RippleOpacity = 25;
            this.browseBtn.Size = new System.Drawing.Size(366, 29);
            this.browseBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.browseBtn.TabIndex = 79;
            this.browseBtn.Text = "Browse";
            this.browseBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.AllowTransparency = true;
            this.backBtn.AnimationInterval = 1;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BGColor = "#508ef5";
            this.backBtn.Corners = 1F;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.backBtn.DoubleRipple = false;
            this.backBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.backBtn.FontColor = "#ffffff";
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(131, 251);
            this.backBtn.Name = "backBtn";
            this.backBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.backBtn.RippleOpacity = 25;
            this.backBtn.Size = new System.Drawing.Size(157, 29);
            this.backBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.backBtn.TabIndex = 80;
            this.backBtn.Text = "Back";
            this.backBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // nextBtn
            // 
            this.nextBtn.AllowTransparency = true;
            this.nextBtn.AnimationInterval = 1;
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.BGColor = "#508ef5";
            this.nextBtn.Corners = 1F;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.nextBtn.DoubleRipple = false;
            this.nextBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.nextBtn.FontColor = "#ffffff";
            this.nextBtn.ForeColor = System.Drawing.Color.Black;
            this.nextBtn.Location = new System.Drawing.Point(340, 251);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.nextBtn.RippleOpacity = 25;
            this.nextBtn.Size = new System.Drawing.Size(157, 29);
            this.nextBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.nextBtn.TabIndex = 81;
            this.nextBtn.Text = "Next";
            this.nextBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click_1);
            // 
            // VendorSignUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PersonalInfoContainer);
            this.Controls.Add(this.label7);
            this.Name = "VendorSignUpView";
            this.Size = new System.Drawing.Size(565, 346);
            this.Load += new System.EventHandler(this.VendorSignUpView_Load);
            this.PersonalInfoContainer.ResumeLayout(false);
            this.PersonalInfoContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalInfoContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label6;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton backBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton browseBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton nextBtn;
    }
}
