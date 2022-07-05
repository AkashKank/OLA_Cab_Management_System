namespace OLA_CAB_Management_Syatem
{
    partial class frm_View_Vehicle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_View_Vehicle = new System.Windows.Forms.DataGridView();
            this.vehicleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_OLA_CAB_Mgt_SystemDataSet1 = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet1();
            this.vehicle_DetailsTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet1TableAdapters.Vehicle_DetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Vehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1727, 81);
            this.panel1.TabIndex = 52;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(419, -8);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(551, 89);
            this.lbl_Header.TabIndex = 12;
            this.lbl_Header.Text = "View All Vehicle";
            // 
            // dgv_View_Vehicle
            // 
            this.dgv_View_Vehicle.AllowUserToAddRows = false;
            this.dgv_View_Vehicle.AllowUserToDeleteRows = false;
            this.dgv_View_Vehicle.AutoGenerateColumns = false;
            this.dgv_View_Vehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Vehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIdDataGridViewTextBoxColumn,
            this.vehicleNameDataGridViewTextBoxColumn,
            this.vehicleNoDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn});
            this.dgv_View_Vehicle.DataSource = this.vehicleDetailsBindingSource;
            this.dgv_View_Vehicle.Location = new System.Drawing.Point(-2, 103);
            this.dgv_View_Vehicle.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_View_Vehicle.Name = "dgv_View_Vehicle";
            this.dgv_View_Vehicle.ReadOnly = true;
            this.dgv_View_Vehicle.RowTemplate.Height = 24;
            this.dgv_View_Vehicle.Size = new System.Drawing.Size(1371, 645);
            this.dgv_View_Vehicle.TabIndex = 53;
            // 
            // vehicleIdDataGridViewTextBoxColumn
            // 
            this.vehicleIdDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Id";
            this.vehicleIdDataGridViewTextBoxColumn.HeaderText = "Vehicle_Id";
            this.vehicleIdDataGridViewTextBoxColumn.Name = "vehicleIdDataGridViewTextBoxColumn";
            this.vehicleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNameDataGridViewTextBoxColumn
            // 
            this.vehicleNameDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Name";
            this.vehicleNameDataGridViewTextBoxColumn.HeaderText = "Vehicle_Name";
            this.vehicleNameDataGridViewTextBoxColumn.Name = "vehicleNameDataGridViewTextBoxColumn";
            this.vehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNoDataGridViewTextBoxColumn
            // 
            this.vehicleNoDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_No";
            this.vehicleNoDataGridViewTextBoxColumn.HeaderText = "Vehicle_No";
            this.vehicleNoDataGridViewTextBoxColumn.Name = "vehicleNoDataGridViewTextBoxColumn";
            this.vehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "Owner_Name";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Owner_Name";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleDetailsBindingSource
            // 
            this.vehicleDetailsBindingSource.DataMember = "Vehicle_Details";
            this.vehicleDetailsBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet1;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet1
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet1.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet1";
            this.dB_OLA_CAB_Mgt_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicle_DetailsTableAdapter
            // 
            this.vehicle_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_Vehicle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_View_Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Vehicle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Vehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Vehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_View_Vehicle;
        private DB_OLA_CAB_Mgt_SystemDataSet1 dB_OLA_CAB_Mgt_SystemDataSet1;
        private System.Windows.Forms.BindingSource vehicleDetailsBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSet1TableAdapters.Vehicle_DetailsTableAdapter vehicle_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
    }
}