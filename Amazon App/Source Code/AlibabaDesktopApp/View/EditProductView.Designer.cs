namespace AlibabaDesktopApp.View
{
    partial class EditProductView
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
            this.productList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productImageBox = new System.Windows.Forms.PictureBox();
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            this.updateBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.browseBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(22, 52);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(155, 290);
            this.productList.TabIndex = 0;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browseBtn);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantityBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productImageBox);
            this.panel1.Location = new System.Drawing.Point(183, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 223);
            this.panel1.TabIndex = 5;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionBox.Location = new System.Drawing.Point(92, 129);
            this.descriptionBox.MaxLength = 100;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(213, 70);
            this.descriptionBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "Description";
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(92, 81);
            this.priceBox.MaxLength = 40;
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(213, 24);
            this.priceBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "Price/prod";
            // 
            // quantityBox
            // 
            this.quantityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.ForeColor = System.Drawing.Color.Black;
            this.quantityBox.Location = new System.Drawing.Point(92, 24);
            this.quantityBox.MaxLength = 40;
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(213, 24);
            this.quantityBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "Quantity";
            // 
            // productImageBox
            // 
            this.productImageBox.Location = new System.Drawing.Point(353, 13);
            this.productImageBox.Name = "productImageBox";
            this.productImageBox.Size = new System.Drawing.Size(120, 146);
            this.productImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImageBox.TabIndex = 29;
            this.productImageBox.TabStop = false;
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(622, 12);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 29;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(275, 310);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.updateBtn.RippleOpacity = 25;
            this.updateBtn.Size = new System.Drawing.Size(381, 32);
            this.updateBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.updateBtn.TabIndex = 68;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
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
            this.browseBtn.Location = new System.Drawing.Point(353, 168);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.browseBtn.RippleOpacity = 25;
            this.browseBtn.Size = new System.Drawing.Size(120, 31);
            this.browseBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.browseBtn.TabIndex = 69;
            this.browseBtn.Text = "Broswe";
            this.browseBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click_1);
            // 
            // EditProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.backToHomeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productList);
            this.Name = "EditProductView";
            this.Size = new System.Drawing.Size(682, 373);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox productImageBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox backToHomeBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton updateBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton browseBtn;
    }
}
