namespace AlibabaDesktopApp.View
{
    partial class CustomerBankAccountDetails
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
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bankBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateBtnn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(512, 15);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 16;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateBtnn);
            this.groupBox1.Controls.Add(this.balanceBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.accountNumberBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cnicBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bankBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(19, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 278);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // balanceBox
            // 
            this.balanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBox.ForeColor = System.Drawing.Color.Black;
            this.balanceBox.Location = new System.Drawing.Point(131, 173);
            this.balanceBox.MaxLength = 40;
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(366, 24);
            this.balanceBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "Balance";
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNumberBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberBox.ForeColor = System.Drawing.Color.Black;
            this.accountNumberBox.Location = new System.Drawing.Point(131, 84);
            this.accountNumberBox.MaxLength = 40;
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(366, 24);
            this.accountNumberBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Account Number";
            // 
            // cnicBox
            // 
            this.cnicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnicBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicBox.ForeColor = System.Drawing.Color.Black;
            this.cnicBox.Location = new System.Drawing.Point(131, 127);
            this.cnicBox.MaxLength = 40;
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.ReadOnly = true;
            this.cnicBox.Size = new System.Drawing.Size(366, 31);
            this.cnicBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "CNIC";
            // 
            // bankBox
            // 
            this.bankBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankBox.FormattingEnabled = true;
            this.bankBox.Items.AddRange(new object[] {
            "Allied Bank Limited",
            "Bank-Al-Habib",
            "Muslim Commercial Bank",
            "National Bank of Pakistan",
            "United Bank Limited"});
            this.bankBox.Location = new System.Drawing.Point(131, 43);
            this.bankBox.Name = "bankBox";
            this.bankBox.Size = new System.Drawing.Size(366, 25);
            this.bankBox.Sorted = true;
            this.bankBox.TabIndex = 33;
            this.bankBox.Text = "Select Bank";
            this.bankBox.SelectedIndexChanged += new System.EventHandler(this.bankBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bank";
            // 
            // updateBtnn
            // 
            this.updateBtnn.AllowTransparency = true;
            this.updateBtnn.AnimationInterval = 1;
            this.updateBtnn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtnn.BGColor = "#508ef5";
            this.updateBtnn.Corners = 1F;
            this.updateBtnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtnn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.updateBtnn.DoubleRipple = false;
            this.updateBtnn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.updateBtnn.FontColor = "#ffffff";
            this.updateBtnn.ForeColor = System.Drawing.Color.Black;
            this.updateBtnn.Location = new System.Drawing.Point(131, 217);
            this.updateBtnn.Name = "updateBtnn";
            this.updateBtnn.RippleEffectColor = System.Drawing.Color.Black;
            this.updateBtnn.RippleOpacity = 25;
            this.updateBtnn.Size = new System.Drawing.Size(366, 29);
            this.updateBtnn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.updateBtnn.TabIndex = 63;
            this.updateBtnn.Text = "Update";
            this.updateBtnn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.updateBtnn.Click += new System.EventHandler(this.updateBtnn_Click);
            // 
            // CustomerBankAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backToHomeBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerBankAccountDetails";
            this.Size = new System.Drawing.Size(565, 346);
            this.Load += new System.EventHandler(this.CustomerBankAccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backToHomeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bankBox;
        private System.Windows.Forms.Label label5;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton updateBtnn;
    }
}
