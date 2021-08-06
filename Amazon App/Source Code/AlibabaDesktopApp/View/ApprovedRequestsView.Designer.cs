namespace AlibabaDesktopApp.View
{
    partial class ApprovedRequestsView
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
            this.approvedRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(639, 12);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 6;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // approvedRequests
            // 
            this.approvedRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approvedRequests.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.approvedRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvedRequests.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.approvedRequests.Location = new System.Drawing.Point(27, 61);
            this.approvedRequests.MultiSelect = false;
            this.approvedRequests.Name = "approvedRequests";
            this.approvedRequests.Size = new System.Drawing.Size(646, 319);
            this.approvedRequests.TabIndex = 7;
            // 
            // ApprovedRequestsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.approvedRequests);
            this.Controls.Add(this.backToHomeBtn);
            this.Name = "ApprovedRequestsView";
            this.Size = new System.Drawing.Size(700, 420);
            this.Load += new System.EventHandler(this.ApprovedRequestsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backToHomeBtn;
        private System.Windows.Forms.DataGridView approvedRequests;
    }
}
