namespace AlibabaDesktopApp.View
{
    partial class RemoveProductView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productImageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListBox();
            this.removeBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(620, 21);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 34;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantityBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productImageBox);
            this.panel1.Location = new System.Drawing.Point(181, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 223);
            this.panel1.TabIndex = 32;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Enabled = false;
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
            this.priceBox.Enabled = false;
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
            this.quantityBox.Enabled = false;
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
            this.productImageBox.Location = new System.Drawing.Point(323, 13);
            this.productImageBox.Name = "productImageBox";
            this.productImageBox.Size = new System.Drawing.Size(150, 186);
            this.productImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImageBox.TabIndex = 29;
            this.productImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Products";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(20, 61);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(155, 290);
            this.productList.TabIndex = 30;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.AllowTransparency = true;
            this.removeBtn.AnimationInterval = 1;
            this.removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeBtn.BGColor = "#508ef5";
            this.removeBtn.Corners = 1F;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.removeBtn.DoubleRipple = false;
            this.removeBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.removeBtn.FontColor = "#ffffff";
            this.removeBtn.ForeColor = System.Drawing.Color.Black;
            this.removeBtn.Location = new System.Drawing.Point(273, 322);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.removeBtn.RippleOpacity = 25;
            this.removeBtn.Size = new System.Drawing.Size(390, 29);
            this.removeBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.removeBtn.TabIndex = 74;
            this.removeBtn.Text = "Remove Product";
            this.removeBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // RemoveProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.backToHomeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productList);
            this.Name = "RemoveProductView";
            this.Size = new System.Drawing.Size(682, 373);
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backToHomeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox productImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox productList;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton removeBtn;
    }
}
