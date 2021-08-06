namespace AlibabaDesktopApp.View
{
    partial class WishListItemsView
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
            this.cartItemContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backTohome = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backTohome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cartItemContainer
            // 
            this.cartItemContainer.AutoScroll = true;
            this.cartItemContainer.Location = new System.Drawing.Point(48, 178);
            this.cartItemContainer.Name = "cartItemContainer";
            this.cartItemContainer.Size = new System.Drawing.Size(781, 346);
            this.cartItemContainer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "My WishList";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AlibabaDesktopApp.Properties.Resources.background3;
            this.panel1.Controls.Add(this.backTohome);
            this.panel1.Controls.Add(this.titleBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 100);
            this.panel1.TabIndex = 7;
            // 
            // backTohome
            // 
            this.backTohome.BackgroundImage = global::AlibabaDesktopApp.Properties.Resources.background3;
            this.backTohome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backTohome.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backTohome.Location = new System.Drawing.Point(22, 22);
            this.backTohome.Name = "backTohome";
            this.backTohome.Size = new System.Drawing.Size(56, 58);
            this.backTohome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backTohome.TabIndex = 0;
            this.backTohome.TabStop = false;
            this.backTohome.Click += new System.EventHandler(this.backTohome_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackgroundImage = global::AlibabaDesktopApp.Properties.Resources.background3;
            this.titleBar.Image = global::AlibabaDesktopApp.Properties.Resources.Amazon_logo;
            this.titleBar.Location = new System.Drawing.Point(84, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(784, 100);
            this.titleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleBar.TabIndex = 1;
            this.titleBar.TabStop = false;
            // 
            // WishListItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartItemContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "WishListItemsView";
            this.Size = new System.Drawing.Size(869, 535);
            this.Load += new System.EventHandler(this.WishListItemsView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backTohome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cartItemContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backTohome;
        private System.Windows.Forms.PictureBox titleBar;
    }
}
