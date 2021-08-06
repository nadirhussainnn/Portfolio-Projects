namespace AlibabaDesktopApp.View
{
    partial class RemoveVendorView
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
            this.allVendors = new System.Windows.Forms.DataGridView();
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            this.removeSelectedBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.removeAllBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.allVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // allVendors
            // 
            this.allVendors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allVendors.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.allVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allVendors.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.allVendors.Location = new System.Drawing.Point(27, 75);
            this.allVendors.MultiSelect = false;
            this.allVendors.Name = "allVendors";
            this.allVendors.Size = new System.Drawing.Size(646, 319);
            this.allVendors.TabIndex = 13;
            this.allVendors.SelectionChanged += new System.EventHandler(this.allVendors_SelectionChanged);
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(639, 26);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 12;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // removeSelectedBtn
            // 
            this.removeSelectedBtn.AllowTransparency = true;
            this.removeSelectedBtn.AnimationInterval = 1;
            this.removeSelectedBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeSelectedBtn.BGColor = "#508ef5";
            this.removeSelectedBtn.Corners = 1F;
            this.removeSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.removeSelectedBtn.DoubleRipple = false;
            this.removeSelectedBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.removeSelectedBtn.FontColor = "#ffffff";
            this.removeSelectedBtn.ForeColor = System.Drawing.Color.Black;
            this.removeSelectedBtn.Location = new System.Drawing.Point(27, 28);
            this.removeSelectedBtn.Name = "removeSelectedBtn";
            this.removeSelectedBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.removeSelectedBtn.RippleOpacity = 25;
            this.removeSelectedBtn.Size = new System.Drawing.Size(158, 31);
            this.removeSelectedBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.removeSelectedBtn.TabIndex = 75;
            this.removeSelectedBtn.Text = "Remove Selected";
            this.removeSelectedBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.removeSelectedBtn.Click += new System.EventHandler(this.removeSelectedBtn_Click_1);
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.AllowTransparency = true;
            this.removeAllBtn.AnimationInterval = 1;
            this.removeAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeAllBtn.BGColor = "#508ef5";
            this.removeAllBtn.Corners = 1F;
            this.removeAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAllBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.removeAllBtn.DoubleRipple = false;
            this.removeAllBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.removeAllBtn.FontColor = "#ffffff";
            this.removeAllBtn.ForeColor = System.Drawing.Color.Black;
            this.removeAllBtn.Location = new System.Drawing.Point(206, 28);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.removeAllBtn.RippleOpacity = 25;
            this.removeAllBtn.Size = new System.Drawing.Size(158, 31);
            this.removeAllBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.removeAllBtn.TabIndex = 76;
            this.removeAllBtn.Text = "Remove All";
            this.removeAllBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click_1);
            // 
            // RemoveVendorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeAllBtn);
            this.Controls.Add(this.removeSelectedBtn);
            this.Controls.Add(this.allVendors);
            this.Controls.Add(this.backToHomeBtn);
            this.Name = "RemoveVendorView";
            this.Size = new System.Drawing.Size(700, 420);
            this.Load += new System.EventHandler(this.RemoveVendorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allVendors;
        private System.Windows.Forms.PictureBox backToHomeBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton removeSelectedBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton removeAllBtn;
    }
}
