namespace AlibabaDesktopApp.View
{
    partial class CreateBankAccountView
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
            this.attachBankAccountContainer = new System.Windows.Forms.Panel();
            this.confirmBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.backBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.bankComboBox = new System.Windows.Forms.ComboBox();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createBankAccountContainer = new System.Windows.Forms.Panel();
            this.createBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.cancelAndExitBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.bankBoxOnCreate = new System.Windows.Forms.ComboBox();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hereBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.attachBankAccountContainer.SuspendLayout();
            this.createBankAccountContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.attachBankAccountContainer);
            this.groupBox1.Controls.Add(this.createBankAccountContainer);
            this.groupBox1.Controls.Add(this.hereBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(19, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 308);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // attachBankAccountContainer
            // 
            this.attachBankAccountContainer.Controls.Add(this.confirmBtn);
            this.attachBankAccountContainer.Controls.Add(this.backBtn);
            this.attachBankAccountContainer.Controls.Add(this.bankComboBox);
            this.attachBankAccountContainer.Controls.Add(this.accountNumberBox);
            this.attachBankAccountContainer.Controls.Add(this.label2);
            this.attachBankAccountContainer.Controls.Add(this.label1);
            this.attachBankAccountContainer.Location = new System.Drawing.Point(11, 19);
            this.attachBankAccountContainer.Name = "attachBankAccountContainer";
            this.attachBankAccountContainer.Size = new System.Drawing.Size(498, 141);
            this.attachBankAccountContainer.TabIndex = 37;
            // 
            // confirmBtn
            // 
            this.confirmBtn.AllowTransparency = true;
            this.confirmBtn.AnimationInterval = 1;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BGColor = "#508ef5";
            this.confirmBtn.Corners = 1F;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.confirmBtn.DoubleRipple = false;
            this.confirmBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.confirmBtn.FontColor = "#ffffff";
            this.confirmBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmBtn.Location = new System.Drawing.Point(329, 87);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.confirmBtn.RippleOpacity = 25;
            this.confirmBtn.Size = new System.Drawing.Size(157, 29);
            this.confirmBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.confirmBtn.TabIndex = 61;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click_1);
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
            this.backBtn.Location = new System.Drawing.Point(120, 87);
            this.backBtn.Name = "backBtn";
            this.backBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.backBtn.RippleOpacity = 25;
            this.backBtn.Size = new System.Drawing.Size(157, 29);
            this.backBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.backBtn.TabIndex = 60;
            this.backBtn.Text = "Back";
            this.backBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // bankComboBox
            // 
            this.bankComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankComboBox.FormattingEnabled = true;
            this.bankComboBox.Items.AddRange(new object[] {
            "Allied Bank Limited",
            "Bank-Al-Habib",
            "Muslim Commercial Bank",
            "National Bank of Pakistan",
            "United Bank Limited"});
            this.bankComboBox.Location = new System.Drawing.Point(120, 6);
            this.bankComboBox.Name = "bankComboBox";
            this.bankComboBox.Size = new System.Drawing.Size(366, 25);
            this.bankComboBox.Sorted = true;
            this.bankComboBox.TabIndex = 27;
            this.bankComboBox.Text = "Select Bank";
            this.bankComboBox.SelectedIndexChanged += new System.EventHandler(this.bankComboBox_SelectedIndexChanged);
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNumberBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberBox.ForeColor = System.Drawing.Color.Black;
            this.accountNumberBox.Location = new System.Drawing.Point(120, 46);
            this.accountNumberBox.MaxLength = 40;
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(366, 24);
            this.accountNumberBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bank";
            // 
            // createBankAccountContainer
            // 
            this.createBankAccountContainer.Controls.Add(this.createBtn);
            this.createBankAccountContainer.Controls.Add(this.cancelAndExitBtn);
            this.createBankAccountContainer.Controls.Add(this.bankBoxOnCreate);
            this.createBankAccountContainer.Controls.Add(this.cnicBox);
            this.createBankAccountContainer.Controls.Add(this.label4);
            this.createBankAccountContainer.Controls.Add(this.label5);
            this.createBankAccountContainer.Location = new System.Drawing.Point(10, 183);
            this.createBankAccountContainer.Name = "createBankAccountContainer";
            this.createBankAccountContainer.Size = new System.Drawing.Size(500, 117);
            this.createBankAccountContainer.TabIndex = 36;
            // 
            // createBtn
            // 
            this.createBtn.AllowTransparency = true;
            this.createBtn.AnimationInterval = 1;
            this.createBtn.BackColor = System.Drawing.Color.Transparent;
            this.createBtn.BGColor = "#508ef5";
            this.createBtn.Corners = 1F;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.createBtn.DoubleRipple = false;
            this.createBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.createBtn.FontColor = "#ffffff";
            this.createBtn.ForeColor = System.Drawing.Color.Black;
            this.createBtn.Location = new System.Drawing.Point(331, 80);
            this.createBtn.Name = "createBtn";
            this.createBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.createBtn.RippleOpacity = 25;
            this.createBtn.Size = new System.Drawing.Size(157, 29);
            this.createBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.createBtn.TabIndex = 63;
            this.createBtn.Text = "Create";
            this.createBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click_1);
            // 
            // cancelAndExitBtn
            // 
            this.cancelAndExitBtn.AllowTransparency = true;
            this.cancelAndExitBtn.AnimationInterval = 1;
            this.cancelAndExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelAndExitBtn.BGColor = "#508ef5";
            this.cancelAndExitBtn.Corners = 1F;
            this.cancelAndExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelAndExitBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.cancelAndExitBtn.DoubleRipple = false;
            this.cancelAndExitBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.cancelAndExitBtn.FontColor = "#ffffff";
            this.cancelAndExitBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelAndExitBtn.Location = new System.Drawing.Point(120, 80);
            this.cancelAndExitBtn.Name = "cancelAndExitBtn";
            this.cancelAndExitBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.cancelAndExitBtn.RippleOpacity = 25;
            this.cancelAndExitBtn.Size = new System.Drawing.Size(157, 29);
            this.cancelAndExitBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cancelAndExitBtn.TabIndex = 62;
            this.cancelAndExitBtn.Text = "Cancel and Exit";
            this.cancelAndExitBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cancelAndExitBtn.Click += new System.EventHandler(this.cancelAndExitBtn_Click_1);
            // 
            // bankBoxOnCreate
            // 
            this.bankBoxOnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankBoxOnCreate.FormattingEnabled = true;
            this.bankBoxOnCreate.Items.AddRange(new object[] {
            "Allied Bank Limited",
            "Bank-Al-Habib",
            "Muslim Commercial Bank",
            "National Bank of Pakistan",
            "United Bank Limited"});
            this.bankBoxOnCreate.Location = new System.Drawing.Point(121, 48);
            this.bankBoxOnCreate.Name = "bankBoxOnCreate";
            this.bankBoxOnCreate.Size = new System.Drawing.Size(366, 25);
            this.bankBoxOnCreate.Sorted = true;
            this.bankBoxOnCreate.TabIndex = 33;
            this.bankBoxOnCreate.Text = "Select Bank";
            this.bankBoxOnCreate.SelectedIndexChanged += new System.EventHandler(this.bankBoxOnCreate_SelectedIndexChanged);
            // 
            // cnicBox
            // 
            this.cnicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cnicBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicBox.ForeColor = System.Drawing.Color.Black;
            this.cnicBox.Location = new System.Drawing.Point(121, 6);
            this.cnicBox.MaxLength = 40;
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(366, 24);
            this.cnicBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "CNIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bank";
            // 
            // hereBtn
            // 
            this.hereBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hereBtn.FlatAppearance.BorderSize = 0;
            this.hereBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hereBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hereBtn.ForeColor = System.Drawing.Color.Blue;
            this.hereBtn.Location = new System.Drawing.Point(348, 160);
            this.hereBtn.Name = "hereBtn";
            this.hereBtn.Size = new System.Drawing.Size(44, 23);
            this.hereBtn.TabIndex = 29;
            this.hereBtn.Text = "Here";
            this.hereBtn.UseVisualStyleBackColor = true;
            this.hereBtn.Click += new System.EventHandler(this.hereBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Don\'t have Bank Account? Create";
            // 
            // CreateBankAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateBankAccountView";
            this.Size = new System.Drawing.Size(565, 346);
            this.Load += new System.EventHandler(this.CreateBankAccountView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.attachBankAccountContainer.ResumeLayout(false);
            this.attachBankAccountContainer.PerformLayout();
            this.createBankAccountContainer.ResumeLayout(false);
            this.createBankAccountContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bankComboBox;
        private System.Windows.Forms.Button hereBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bankBoxOnCreate;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel createBankAccountContainer;
        private System.Windows.Forms.Panel attachBankAccountContainer;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton confirmBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton backBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton createBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton cancelAndExitBtn;
    }
}
