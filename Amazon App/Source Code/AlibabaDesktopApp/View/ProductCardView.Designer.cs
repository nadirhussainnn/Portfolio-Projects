namespace AlibabaDesktopApp.View
{
    partial class ProductCardView
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
            this.prodName = new System.Windows.Forms.Label();
            this.prodDetails = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.Label();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.addtoWishListBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.addToCartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.SuspendLayout();
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(3, 172);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(148, 14);
            this.prodName.TabIndex = 1;
            this.prodName.Text = "Name: ";
            // 
            // prodDetails
            // 
            this.prodDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDetails.Location = new System.Drawing.Point(3, 189);
            this.prodDetails.Name = "prodDetails";
            this.prodDetails.Size = new System.Drawing.Size(148, 13);
            this.prodDetails.TabIndex = 2;
            this.prodDetails.Text = "Details: ";
            // 
            // prodPrice
            // 
            this.prodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPrice.ForeColor = System.Drawing.Color.Blue;
            this.prodPrice.Location = new System.Drawing.Point(3, 207);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(148, 13);
            this.prodPrice.TabIndex = 3;
            this.prodPrice.Text = "Price: ";
            // 
            // productPic
            // 
            this.productPic.Image = global::AlibabaDesktopApp.Properties.Resources.dslr_camera;
            this.productPic.Location = new System.Drawing.Point(2, 27);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(152, 143);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 0;
            this.productPic.TabStop = false;
            // 
            // addtoWishListBtn
            // 
            this.addtoWishListBtn.AllowTransparency = true;
            this.addtoWishListBtn.AnimationInterval = 1;
            this.addtoWishListBtn.BackColor = System.Drawing.Color.Transparent;
            this.addtoWishListBtn.BGColor = "#508ef5";
            this.addtoWishListBtn.Corners = 1F;
            this.addtoWishListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtoWishListBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.addtoWishListBtn.DoubleRipple = false;
            this.addtoWishListBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.addtoWishListBtn.FontColor = "#ffffff";
            this.addtoWishListBtn.ForeColor = System.Drawing.Color.Black;
            this.addtoWishListBtn.Location = new System.Drawing.Point(-2, -1);
            this.addtoWishListBtn.Name = "addtoWishListBtn";
            this.addtoWishListBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.addtoWishListBtn.RippleOpacity = 25;
            this.addtoWishListBtn.Size = new System.Drawing.Size(160, 29);
            this.addtoWishListBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.addtoWishListBtn.TabIndex = 73;
            this.addtoWishListBtn.Text = "Add to Wishlist";
            this.addtoWishListBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.addtoWishListBtn.Click += new System.EventHandler(this.addtoWishListBtn_Click_1);
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
            this.addToCartBtn.Location = new System.Drawing.Point(-2, 222);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.addToCartBtn.RippleOpacity = 25;
            this.addToCartBtn.Size = new System.Drawing.Size(160, 29);
            this.addToCartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.addToCartBtn.TabIndex = 74;
            this.addToCartBtn.Text = "Add to Cart";
            this.addToCartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click_1);
            // 
            // ProductCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.addtoWishListBtn);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodDetails);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.productPic);
            this.Name = "ProductCardView";
            this.Size = new System.Drawing.Size(156, 250);
            this.Load += new System.EventHandler(this.ProductCardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.Label prodDetails;
        private System.Windows.Forms.Label prodPrice;
        private System.Windows.Forms.PictureBox productPic;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton addtoWishListBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton addToCartBtn;
    }
}
