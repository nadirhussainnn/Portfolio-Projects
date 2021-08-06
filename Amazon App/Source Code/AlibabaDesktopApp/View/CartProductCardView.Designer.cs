namespace AlibabaDesktopApp.View
{
    partial class CartProductCardView
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateAddedLabel = new System.Windows.Forms.Label();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.purchaseBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.removeFromcartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.Blue;
            this.priceLabel.Location = new System.Drawing.Point(9, 230);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(131, 18);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price: ";
            // 
            // dateAddedLabel
            // 
            this.dateAddedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedLabel.Location = new System.Drawing.Point(137, 234);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(91, 18);
            this.dateAddedLabel.TabIndex = 7;
            this.dateAddedLabel.Text = "Date Added:";
            // 
            // productPic
            // 
            this.productPic.Image = global::AlibabaDesktopApp.Properties.Resources.dslr_camera;
            this.productPic.Location = new System.Drawing.Point(3, 3);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(225, 220);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 6;
            this.productPic.TabStop = false;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.AllowTransparency = true;
            this.purchaseBtn.AnimationInterval = 1;
            this.purchaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.purchaseBtn.BGColor = "#508ef5";
            this.purchaseBtn.Corners = 1F;
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.purchaseBtn.DoubleRipple = false;
            this.purchaseBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.purchaseBtn.FontColor = "#ffffff";
            this.purchaseBtn.ForeColor = System.Drawing.Color.Black;
            this.purchaseBtn.Location = new System.Drawing.Point(3, 254);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.purchaseBtn.RippleOpacity = 25;
            this.purchaseBtn.Size = new System.Drawing.Size(106, 27);
            this.purchaseBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.purchaseBtn.TabIndex = 47;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click_1);
            // 
            // removeFromcartBtn
            // 
            this.removeFromcartBtn.AllowTransparency = true;
            this.removeFromcartBtn.AnimationInterval = 1;
            this.removeFromcartBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeFromcartBtn.BGColor = "#508ef5";
            this.removeFromcartBtn.Corners = 1F;
            this.removeFromcartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFromcartBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.removeFromcartBtn.DoubleRipple = false;
            this.removeFromcartBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.removeFromcartBtn.FontColor = "#ffffff";
            this.removeFromcartBtn.ForeColor = System.Drawing.Color.Black;
            this.removeFromcartBtn.Location = new System.Drawing.Point(128, 254);
            this.removeFromcartBtn.Name = "removeFromcartBtn";
            this.removeFromcartBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.removeFromcartBtn.RippleOpacity = 25;
            this.removeFromcartBtn.Size = new System.Drawing.Size(101, 27);
            this.removeFromcartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.removeFromcartBtn.TabIndex = 48;
            this.removeFromcartBtn.Text = "Remove";
            this.removeFromcartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.removeFromcartBtn.Click += new System.EventHandler(this.removeFromcartBtn_Click_1);
            // 
            // CartProductCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeFromcartBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.productPic);
            this.Name = "CartProductCardView";
            this.Size = new System.Drawing.Size(230, 285);
            this.Load += new System.EventHandler(this.CartProductCardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label dateAddedLabel;
        private System.Windows.Forms.PictureBox productPic;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton purchaseBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton removeFromcartBtn;
    }
}
