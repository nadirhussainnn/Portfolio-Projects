namespace Car_Parking_System
{
    partial class ParkedCar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chalanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parking_DBDataSet = new Car_Parking_System.Parking_DBDataSet();
            this.carsTableAdapter = new Car_Parking_System.Parking_DBDataSetTableAdapters.CarsTableAdapter();
            this.fillBy4ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy4ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_DBDataSet)).BeginInit();
            this.fillBy4ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.regNoDataGridViewTextBoxColumn,
            this.chalanDataGridViewTextBoxColumn,
            this.tokenDataGridViewTextBoxColumn,
            this.parkeddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "Reg_No";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "Reg_No";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            this.regNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chalanDataGridViewTextBoxColumn
            // 
            this.chalanDataGridViewTextBoxColumn.DataPropertyName = "Chalan";
            this.chalanDataGridViewTextBoxColumn.HeaderText = "Chalan";
            this.chalanDataGridViewTextBoxColumn.Name = "chalanDataGridViewTextBoxColumn";
            this.chalanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tokenDataGridViewTextBoxColumn
            // 
            this.tokenDataGridViewTextBoxColumn.DataPropertyName = "Token";
            this.tokenDataGridViewTextBoxColumn.HeaderText = "Token";
            this.tokenDataGridViewTextBoxColumn.Name = "tokenDataGridViewTextBoxColumn";
            this.tokenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkeddateDataGridViewTextBoxColumn
            // 
            this.parkeddateDataGridViewTextBoxColumn.DataPropertyName = "Parked_date";
            this.parkeddateDataGridViewTextBoxColumn.HeaderText = "Parked_date";
            this.parkeddateDataGridViewTextBoxColumn.Name = "parkeddateDataGridViewTextBoxColumn";
            this.parkeddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.parking_DBDataSet;
            // 
            // parking_DBDataSet
            // 
            this.parking_DBDataSet.DataSetName = "Parking_DBDataSet";
            this.parking_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy4ToolStrip
            // 
            this.fillBy4ToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fillBy4ToolStrip.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBy4ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy4ToolStripButton});
            this.fillBy4ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy4ToolStrip.Name = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.Size = new System.Drawing.Size(646, 25);
            this.fillBy4ToolStrip.TabIndex = 1;
            this.fillBy4ToolStrip.Text = "Show Parked Cars";
            // 
            // fillBy4ToolStripButton
            // 
            this.fillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy4ToolStripButton.Name = "fillBy4ToolStripButton";
            this.fillBy4ToolStripButton.Size = new System.Drawing.Size(190, 22);
            this.fillBy4ToolStripButton.Text = "Show Parked Cars";
            this.fillBy4ToolStripButton.Click += new System.EventHandler(this.fillBy4ToolStripButton_Click);
            // 
            // ParkedCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillBy4ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParkedCar";
            this.Size = new System.Drawing.Size(646, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_DBDataSet)).EndInit();
            this.fillBy4ToolStrip.ResumeLayout(false);
            this.fillBy4ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chalanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Parking_DBDataSet parking_DBDataSet;
        private Parking_DBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy4ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy4ToolStripButton;
    }
}
