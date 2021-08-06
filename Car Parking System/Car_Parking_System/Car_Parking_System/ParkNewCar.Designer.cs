namespace Car_Parking_System
{
    partial class ParkNewCar
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
            this.RegNo = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Car_Type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chalan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegNo
            // 
            this.RegNo.AutoSize = true;
            this.RegNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNo.Location = new System.Drawing.Point(46, 57);
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(65, 19);
            this.RegNo.TabIndex = 0;
            this.RegNo.Text = "Reg No";
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(130, 58);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(194, 20);
            this.reg.TabIndex = 1;
            this.reg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(130, 95);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(194, 20);
            this.model.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(46, 93);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(58, 19);
            this.Type.TabIndex = 2;
            this.Type.Text = "Model";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Park";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Car_Type
            // 
            this.Car_Type.Location = new System.Drawing.Point(130, 26);
            this.Car_Type.Name = "Car_Type";
            this.Car_Type.Size = new System.Drawing.Size(194, 20);
            this.Car_Type.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Type";
            // 
            // chalan
            // 
            this.chalan.Location = new System.Drawing.Point(130, 125);
            this.chalan.Name = "chalan";
            this.chalan.Size = new System.Drawing.Size(194, 20);
            this.chalan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chalan";
            // 
            // ParkNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chalan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Car_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.model);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.RegNo);
            this.Name = "ParkNewCar";
            this.Size = new System.Drawing.Size(426, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegNo;
        private System.Windows.Forms.TextBox reg;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Car_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chalan;
        private System.Windows.Forms.Label label2;
    }
}
