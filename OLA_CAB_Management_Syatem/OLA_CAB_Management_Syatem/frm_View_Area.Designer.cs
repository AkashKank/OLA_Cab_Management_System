namespace OLA_CAB_Management_Syatem
{
    partial class frm_View_Area
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
            this.dgv_View_All_Area = new System.Windows.Forms.DataGridView();
            this.areaDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_OLA_CAB_Mgt_SystemDataSet2 = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet2();
            this.area_DetailsTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet2TableAdapters.Area_DetailsTableAdapter();
            this.dB_OLA_CAB_Mgt_SystemDataSet5 = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet5();
            this.areaDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.area_DetailTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet5TableAdapters.Area_DetailTableAdapter();
            this.areaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeKmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carKmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1727, 81);
            this.panel1.TabIndex = 53;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(467, -8);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(468, 89);
            this.lbl_Header.TabIndex = 12;
            this.lbl_Header.Text = "View All Area";
            // 
            // dgv_View_All_Area
            // 
            this.dgv_View_All_Area.AllowUserToAddRows = false;
            this.dgv_View_All_Area.AllowUserToDeleteRows = false;
            this.dgv_View_All_Area.AutoGenerateColumns = false;
            this.dgv_View_All_Area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaIdDataGridViewTextBoxColumn,
            this.areaNameDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.bikeKmPriceDataGridViewTextBoxColumn,
            this.carKmPriceDataGridViewTextBoxColumn});
            this.dgv_View_All_Area.DataSource = this.areaDetailBindingSource;
            this.dgv_View_All_Area.Location = new System.Drawing.Point(-1, 136);
            this.dgv_View_All_Area.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_View_All_Area.Name = "dgv_View_All_Area";
            this.dgv_View_All_Area.ReadOnly = true;
            this.dgv_View_All_Area.RowTemplate.Height = 24;
            this.dgv_View_All_Area.Size = new System.Drawing.Size(1370, 613);
            this.dgv_View_All_Area.TabIndex = 54;
            // 
            // areaDetailsBindingSource
            // 
            this.areaDetailsBindingSource.DataMember = "Area_Details";
            this.areaDetailsBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet2;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet2
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet2.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet2";
            this.dB_OLA_CAB_Mgt_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // area_DetailsTableAdapter
            // 
            this.area_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet5
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet5.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet5";
            this.dB_OLA_CAB_Mgt_SystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaDetailBindingSource
            // 
            this.areaDetailBindingSource.DataMember = "Area_Detail";
            this.areaDetailBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet5;
            // 
            // area_DetailTableAdapter
            // 
            this.area_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // areaIdDataGridViewTextBoxColumn
            // 
            this.areaIdDataGridViewTextBoxColumn.DataPropertyName = "Area_Id";
            this.areaIdDataGridViewTextBoxColumn.HeaderText = "Area_Id";
            this.areaIdDataGridViewTextBoxColumn.Name = "areaIdDataGridViewTextBoxColumn";
            this.areaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaNameDataGridViewTextBoxColumn
            // 
            this.areaNameDataGridViewTextBoxColumn.DataPropertyName = "Area_Name";
            this.areaNameDataGridViewTextBoxColumn.HeaderText = "Area_Name";
            this.areaNameDataGridViewTextBoxColumn.Name = "areaNameDataGridViewTextBoxColumn";
            this.areaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            this.kmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bikeKmPriceDataGridViewTextBoxColumn
            // 
            this.bikeKmPriceDataGridViewTextBoxColumn.DataPropertyName = "Bike_Km_Price";
            this.bikeKmPriceDataGridViewTextBoxColumn.HeaderText = "Bike_Km_Price";
            this.bikeKmPriceDataGridViewTextBoxColumn.Name = "bikeKmPriceDataGridViewTextBoxColumn";
            this.bikeKmPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carKmPriceDataGridViewTextBoxColumn
            // 
            this.carKmPriceDataGridViewTextBoxColumn.DataPropertyName = "Car_Km_Price";
            this.carKmPriceDataGridViewTextBoxColumn.HeaderText = "Car_Km_Price";
            this.carKmPriceDataGridViewTextBoxColumn.Name = "carKmPriceDataGridViewTextBoxColumn";
            this.carKmPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_All_Area);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_View_Area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Area";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Area_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_View_All_Area;
        private DB_OLA_CAB_Mgt_SystemDataSet2 dB_OLA_CAB_Mgt_SystemDataSet2;
        private System.Windows.Forms.BindingSource areaDetailsBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSet2TableAdapters.Area_DetailsTableAdapter area_DetailsTableAdapter;
        private DB_OLA_CAB_Mgt_SystemDataSet5 dB_OLA_CAB_Mgt_SystemDataSet5;
        private System.Windows.Forms.BindingSource areaDetailBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSet5TableAdapters.Area_DetailTableAdapter area_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeKmPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carKmPriceDataGridViewTextBoxColumn;
    }
}