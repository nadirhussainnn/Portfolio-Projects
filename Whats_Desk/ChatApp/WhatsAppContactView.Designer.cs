namespace ChatApp
{
    partial class WhatsAppContactView
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.contactNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.firstMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lastMsgTimeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.contactImageBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lastMsgTimeLabel);
            this.panel1.Controls.Add(this.firstMessage);
            this.panel1.Controls.Add(this.contactNameLabel);
            this.panel1.Controls.Add(this.contactImageBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 70);
            this.panel1.TabIndex = 0;
            // 
            // contactNameLabel
            // 
            this.contactNameLabel.AutoSize = true;
            this.contactNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameLabel.Location = new System.Drawing.Point(62, 9);
            this.contactNameLabel.Name = "contactNameLabel";
            this.contactNameLabel.Size = new System.Drawing.Size(99, 16);
            this.contactNameLabel.TabIndex = 1;
            this.contactNameLabel.Text = "Nadir Hussain";
            // 
            // firstMessage
            // 
            this.firstMessage.AutoSize = true;
            this.firstMessage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMessage.Location = new System.Drawing.Point(67, 39);
            this.firstMessage.Name = "firstMessage";
            this.firstMessage.Size = new System.Drawing.Size(119, 16);
            this.firstMessage.TabIndex = 2;
            this.firstMessage.Text = "bunifuCustomLabel2";
            // 
            // lastMsgTimeLabel
            // 
            this.lastMsgTimeLabel.AutoSize = true;
            this.lastMsgTimeLabel.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastMsgTimeLabel.Location = new System.Drawing.Point(200, 9);
            this.lastMsgTimeLabel.Name = "lastMsgTimeLabel";
            this.lastMsgTimeLabel.Size = new System.Drawing.Size(34, 12);
            this.lastMsgTimeLabel.TabIndex = 3;
            this.lastMsgTimeLabel.Text = "8:12PM";
            // 
            // contactImageBox
            // 
            this.contactImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.contactImageBox.Image = global::ChatApp.Properties.Resources.avatar;
            this.contactImageBox.Location = new System.Drawing.Point(0, 0);
            this.contactImageBox.Name = "contactImageBox";
            this.contactImageBox.Size = new System.Drawing.Size(56, 70);
            this.contactImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactImageBox.TabIndex = 0;
            this.contactImageBox.TabStop = false;
            // 
            // WhatsAppContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WhatsAppContactView";
            this.Size = new System.Drawing.Size(245, 70);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lastMsgTimeLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel firstMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel contactNameLabel;
        private System.Windows.Forms.PictureBox contactImageBox;
    }
}
