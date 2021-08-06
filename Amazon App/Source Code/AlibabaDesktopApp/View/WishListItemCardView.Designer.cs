namespace AlibabaDesktopApp.View
{
    partial class WishListItemCardView
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
            this.productPic = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateAddedLabel = new System.Windows.Forms.Label();
            this.addToCartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.removeFromcartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.SuspendLayout();
            // 
            // productPic
            // 
            this.productPic.Image = global::AlibabaDesktopApp.Properties.Resources.dslr_camera;
            this.productPic.Location = new System.Drawing.Point(2, 3);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(225, 220);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 7;
            this.productPic.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.Blue;
            this.priceLabel.Location = new System.Drawing.Point(8, 226);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(107, 18);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price: ";
            // 
            // dateAddedLabel
            // 
            this.dateAddedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedLabel.Location = new System.Drawing.Point(132, 230);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(91, 18);
            this.dateAddedLabel.TabIndex = 12;
            this.dateAddedLabel.Text = "Date Added:";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.AllowTransparency = true;
            this.addToCartBtn.AnimationInterval = 1;
            this.addToCartBtn.BackColor = System.Drawing.Color.Transparent;
            this.addToCartBtn.BGColor = "#508ef5";
            this.addToCartBtn.Corners = 1F;
            this.addToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.addToCartBtn.DoubleRipple = false;
            this.addToCartBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.addToCartBtn.FontColor = "#ffffff";
            this.addToCartBtn.ForeColor = System.Drawing.Color.Black;
            this.addToCartBtn.Location = new System.Drawing.Point(3, 251);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.addToCartBtn.RippleOpacity = 25;
            this.addToCartBtn.Size = new System.Drawing.Size(106, 30);
            this.addToCartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.addToCartBtn.TabIndex = 46;
            this.addToCartBtn.Text = "Add to cart";
            this.addToCartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click_1);
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
            this.removeFromcartBtn.Location = new System.Drawing.Point(117, 251);
            this.removeFromcartBtn.Name = "removeFromcartBtn";
            this.removeFromcartBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.removeFromcartBtn.RippleOpacity = 25;
            this.removeFromcartBtn.Size = new System.Drawing.Size(106, 30);
            this.removeFromcartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.removeFromcartBtn.TabIndex = 47;
            this.removeFromcartBtn.Text = "Remove";
            this.removeFromcartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.removeFromcartBtn.Click += new System.EventHandler(this.removeFromcartBtn_Click_1);
            // 
            // WishListItemCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeFromcartBtn);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.productPic);
            this.Name = "WishListItemCardView";
            this.Size = new System.Drawing.Size(230, 285);
            this.Load += new System.EventHandler(this.WishListItemCardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox productPic;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label dateAddedLabel;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton addToCartBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton removeFromcartBtn;
    }
}
