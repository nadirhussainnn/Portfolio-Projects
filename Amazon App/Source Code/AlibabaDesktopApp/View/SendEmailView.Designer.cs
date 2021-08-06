namespace AlibabaDesktopApp.View
{
    partial class SendEmailView
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
            this.label2 = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorsBox = new System.Windows.Forms.ComboBox();
            this.adminEmailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminPassBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            this.attachBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.sendBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "Send To";
            // 
            // subjectBox
            // 
            this.subjectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectBox.ForeColor = System.Drawing.Color.Black;
            this.subjectBox.Location = new System.Drawing.Point(143, 133);
            this.subjectBox.MaxLength = 40;
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(355, 24);
            this.subjectBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "Subject";
            // 
            // bodyBox
            // 
            this.bodyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bodyBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyBox.ForeColor = System.Drawing.Color.Black;
            this.bodyBox.Location = new System.Drawing.Point(143, 163);
            this.bodyBox.MaxLength = 1000;
            this.bodyBox.Multiline = true;
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(355, 160);
            this.bodyBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "Message Body";
            // 
            // vendorsBox
            // 
            this.vendorsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsBox.FormattingEnabled = true;
            this.vendorsBox.Location = new System.Drawing.Point(143, 106);
            this.vendorsBox.Name = "vendorsBox";
            this.vendorsBox.Size = new System.Drawing.Size(356, 21);
            this.vendorsBox.TabIndex = 41;
            this.vendorsBox.Text = "Select Vendor";
            this.vendorsBox.SelectedIndexChanged += new System.EventHandler(this.vendorsBox_SelectedIndexChanged);
            // 
            // adminEmailBox
            // 
            this.adminEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminEmailBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmailBox.ForeColor = System.Drawing.Color.Black;
            this.adminEmailBox.Location = new System.Drawing.Point(143, 29);
            this.adminEmailBox.MaxLength = 40;
            this.adminEmailBox.Name = "adminEmailBox";
            this.adminEmailBox.Size = new System.Drawing.Size(355, 24);
            this.adminEmailBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "Your Email";
            // 
            // adminPassBox
            // 
            this.adminPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPassBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassBox.ForeColor = System.Drawing.Color.Black;
            this.adminPassBox.Location = new System.Drawing.Point(143, 66);
            this.adminPassBox.MaxLength = 40;
            this.adminPassBox.Name = "adminPassBox";
            this.adminPassBox.PasswordChar = '*';
            this.adminPassBox.Size = new System.Drawing.Size(355, 24);
            this.adminPassBox.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = "Password";
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(578, 20);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 33;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // attachBtn
            // 
            this.attachBtn.AllowTransparency = true;
            this.attachBtn.AnimationInterval = 1;
            this.attachBtn.BackColor = System.Drawing.Color.Transparent;
            this.attachBtn.BGColor = "#508ef5";
            this.attachBtn.Corners = 1F;
            this.attachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.attachBtn.DoubleRipple = false;
            this.attachBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.attachBtn.FontColor = "#ffffff";
            this.attachBtn.ForeColor = System.Drawing.Color.Black;
            this.attachBtn.Location = new System.Drawing.Point(143, 336);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.attachBtn.RippleOpacity = 25;
            this.attachBtn.Size = new System.Drawing.Size(159, 31);
            this.attachBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.attachBtn.TabIndex = 76;
            this.attachBtn.Text = "Attach File";
            this.attachBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click_1);
            // 
            // sendBtn
            // 
            this.sendBtn.AllowTransparency = true;
            this.sendBtn.AnimationInterval = 1;
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.BGColor = "#508ef5";
            this.sendBtn.Corners = 1F;
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.sendBtn.DoubleRipple = false;
            this.sendBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.sendBtn.FontColor = "#ffffff";
            this.sendBtn.ForeColor = System.Drawing.Color.Black;
            this.sendBtn.Location = new System.Drawing.Point(340, 336);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.sendBtn.RippleOpacity = 25;
            this.sendBtn.Size = new System.Drawing.Size(159, 31);
            this.sendBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.sendBtn.TabIndex = 77;
            this.sendBtn.Text = "Send";
            this.sendBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click_1);
            // 
            // SendEmailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.adminPassBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adminEmailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vendorsBox);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backToHomeBtn);
            this.Name = "SendEmailView";
            this.Size = new System.Drawing.Size(630, 375);
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox backToHomeBtn;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vendorsBox;
        private System.Windows.Forms.TextBox adminEmailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminPassBox;
        private System.Windows.Forms.Label label5;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton attachBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton sendBtn;
    }
}
