namespace AlibabaDesktopApp.View
{
    partial class NewRequestsView
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
            this.pendingRequests = new System.Windows.Forms.DataGridView();
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            this.approveSelectedBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.rejectSelectedBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.approveAllBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.rejectAllBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.pendingRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingRequests
            // 
            this.pendingRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendingRequests.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingRequests.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.pendingRequests.Location = new System.Drawing.Point(25, 92);
            this.pendingRequests.MultiSelect = false;
            this.pendingRequests.Name = "pendingRequests";
            this.pendingRequests.Size = new System.Drawing.Size(646, 299);
            this.pendingRequests.TabIndex = 0;
            this.pendingRequests.SelectionChanged += new System.EventHandler(this.pendingRequests_SelectionChanged);
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(637, 4);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 5;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // approveSelectedBtn
            // 
            this.approveSelectedBtn.AllowTransparency = true;
            this.approveSelectedBtn.AnimationInterval = 1;
            this.approveSelectedBtn.BackColor = System.Drawing.Color.Transparent;
            this.approveSelectedBtn.BGColor = "#508ef5";
            this.approveSelectedBtn.Corners = 1F;
            this.approveSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approveSelectedBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.approveSelectedBtn.DoubleRipple = false;
            this.approveSelectedBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.approveSelectedBtn.FontColor = "#ffffff";
            this.approveSelectedBtn.ForeColor = System.Drawing.Color.Black;
            this.approveSelectedBtn.Location = new System.Drawing.Point(30, 50);
            this.approveSelectedBtn.Name = "approveSelectedBtn";
            this.approveSelectedBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.approveSelectedBtn.RippleOpacity = 25;
            this.approveSelectedBtn.Size = new System.Drawing.Size(160, 31);
            this.approveSelectedBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.approveSelectedBtn.TabIndex = 72;
            this.approveSelectedBtn.Text = "Approve Selected";
            this.approveSelectedBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.approveSelectedBtn.Click += new System.EventHandler(this.approveSelectedBtn_Click_1);
            // 
            // rejectSelectedBtn
            // 
            this.rejectSelectedBtn.AllowTransparency = true;
            this.rejectSelectedBtn.AnimationInterval = 1;
            this.rejectSelectedBtn.BackColor = System.Drawing.Color.Transparent;
            this.rejectSelectedBtn.BGColor = "#508ef5";
            this.rejectSelectedBtn.Corners = 1F;
            this.rejectSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectSelectedBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.rejectSelectedBtn.DoubleRipple = false;
            this.rejectSelectedBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.rejectSelectedBtn.FontColor = "#ffffff";
            this.rejectSelectedBtn.ForeColor = System.Drawing.Color.Black;
            this.rejectSelectedBtn.Location = new System.Drawing.Point(209, 50);
            this.rejectSelectedBtn.Name = "rejectSelectedBtn";
            this.rejectSelectedBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.rejectSelectedBtn.RippleOpacity = 25;
            this.rejectSelectedBtn.Size = new System.Drawing.Size(160, 31);
            this.rejectSelectedBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.rejectSelectedBtn.TabIndex = 73;
            this.rejectSelectedBtn.Text = "Reject Selected";
            this.rejectSelectedBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.rejectSelectedBtn.Click += new System.EventHandler(this.rejectSelectedBtn_Click_1);
            // 
            // approveAllBtn
            // 
            this.approveAllBtn.AllowTransparency = true;
            this.approveAllBtn.AnimationInterval = 1;
            this.approveAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.approveAllBtn.BGColor = "#508ef5";
            this.approveAllBtn.Corners = 1F;
            this.approveAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approveAllBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.approveAllBtn.DoubleRipple = false;
            this.approveAllBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.approveAllBtn.FontColor = "#ffffff";
            this.approveAllBtn.ForeColor = System.Drawing.Color.Black;
            this.approveAllBtn.Location = new System.Drawing.Point(387, 50);
            this.approveAllBtn.Name = "approveAllBtn";
            this.approveAllBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.approveAllBtn.RippleOpacity = 25;
            this.approveAllBtn.Size = new System.Drawing.Size(139, 31);
            this.approveAllBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.approveAllBtn.TabIndex = 74;
            this.approveAllBtn.Text = "Approve All";
            this.approveAllBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.approveAllBtn.Click += new System.EventHandler(this.approveAllBtn_Click_1);
            // 
            // rejectAllBtn
            // 
            this.rejectAllBtn.AllowTransparency = true;
            this.rejectAllBtn.AnimationInterval = 1;
            this.rejectAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.rejectAllBtn.BGColor = "#508ef5";
            this.rejectAllBtn.Corners = 1F;
            this.rejectAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectAllBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.rejectAllBtn.DoubleRipple = false;
            this.rejectAllBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.rejectAllBtn.FontColor = "#ffffff";
            this.rejectAllBtn.ForeColor = System.Drawing.Color.Black;
            this.rejectAllBtn.Location = new System.Drawing.Point(532, 50);
            this.rejectAllBtn.Name = "rejectAllBtn";
            this.rejectAllBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.rejectAllBtn.RippleOpacity = 25;
            this.rejectAllBtn.Size = new System.Drawing.Size(139, 31);
            this.rejectAllBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.rejectAllBtn.TabIndex = 75;
            this.rejectAllBtn.Text = "Reject All";
            this.rejectAllBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.rejectAllBtn.Click += new System.EventHandler(this.rejectAllBtn_Click_1);
            // 
            // NewRequestsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rejectAllBtn);
            this.Controls.Add(this.approveAllBtn);
            this.Controls.Add(this.rejectSelectedBtn);
            this.Controls.Add(this.approveSelectedBtn);
            this.Controls.Add(this.backToHomeBtn);
            this.Controls.Add(this.pendingRequests);
            this.Name = "NewRequestsView";
            this.Size = new System.Drawing.Size(700, 420);
            this.Load += new System.EventHandler(this.NewRequestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendingRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pendingRequests;
        private System.Windows.Forms.PictureBox backToHomeBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton approveSelectedBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton rejectSelectedBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton approveAllBtn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton rejectAllBtn;
    }
}
