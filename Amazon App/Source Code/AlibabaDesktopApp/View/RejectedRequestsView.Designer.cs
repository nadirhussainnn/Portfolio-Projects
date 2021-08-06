namespace AlibabaDesktopApp.View
{
    partial class RejectedRequestsView
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
            this.rejectedRequests = new System.Windows.Forms.DataGridView();
            this.backToHomeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // rejectedRequests
            // 
            this.rejectedRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectedRequests.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rejectedRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rejectedRequests.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.rejectedRequests.Location = new System.Drawing.Point(27, 75);
            this.rejectedRequests.MultiSelect = false;
            this.rejectedRequests.Name = "rejectedRequests";
            this.rejectedRequests.Size = new System.Drawing.Size(646, 319);
            this.rejectedRequests.TabIndex = 9;
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHomeBtn.Image = global::AlibabaDesktopApp.Properties.Resources.homepage;
            this.backToHomeBtn.Location = new System.Drawing.Point(639, 26);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(34, 33);
            this.backToHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToHomeBtn.TabIndex = 8;
            this.backToHomeBtn.TabStop = false;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // RejectedRequestsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rejectedRequests);
            this.Controls.Add(this.backToHomeBtn);
            this.Name = "RejectedRequestsView";
            this.Size = new System.Drawing.Size(700, 420);
            this.Load += new System.EventHandler(this.RejectedRequestsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rejectedRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToHomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rejectedRequests;
        private System.Windows.Forms.PictureBox backToHomeBtn;
    }
}
