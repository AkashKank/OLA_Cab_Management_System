namespace OLA_CAB_Management_Syatem
{
    partial class frm_View_Driver
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
            this.dgv_View_Driver = new System.Windows.Forms.DataGridView();
            this.driverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pANNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_OLA_CAB_Mgt_SystemDataSet = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet();
            this.driver_DetailsTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSetTableAdapters.Driver_DetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Driver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1727, 81);
            this.panel1.TabIndex = 51;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(467, -8);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(515, 89);
            this.lbl_Header.TabIndex = 12;
            this.lbl_Header.Text = "View All Driver";
            // 
            // dgv_View_Driver
            // 
            this.dgv_View_Driver.AllowUserToAddRows = false;
            this.dgv_View_Driver.AllowUserToDeleteRows = false;
            this.dgv_View_Driver.AutoGenerateColumns = false;
            this.dgv_View_Driver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Driver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverIdDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.alternateMobileNoDataGridViewTextBoxColumn,
            this.aadharNoDataGridViewTextBoxColumn,
            this.pANNoDataGridViewTextBoxColumn,
            this.licenceNoDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn});
            this.dgv_View_Driver.DataSource = this.driverDetailsBindingSource;
            this.dgv_View_Driver.Location = new System.Drawing.Point(1, 96);
            this.dgv_View_Driver.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_View_Driver.Name = "dgv_View_Driver";
            this.dgv_View_Driver.ReadOnly = true;
            this.dgv_View_Driver.RowTemplate.Height = 24;
            this.dgv_View_Driver.Size = new System.Drawing.Size(1367, 654);
            this.dgv_View_Driver.TabIndex = 52;
            // 
            // driverIdDataGridViewTextBoxColumn
            // 
            this.driverIdDataGridViewTextBoxColumn.DataPropertyName = "Driver_Id";
            this.driverIdDataGridViewTextBoxColumn.HeaderText = "Driver_Id";
            this.driverIdDataGridViewTextBoxColumn.Name = "driverIdDataGridViewTextBoxColumn";
            this.driverIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternateMobileNoDataGridViewTextBoxColumn
            // 
            this.alternateMobileNoDataGridViewTextBoxColumn.DataPropertyName = "Alternate_Mobile_No";
            this.alternateMobileNoDataGridViewTextBoxColumn.HeaderText = "Alternate_Mobile_No";
            this.alternateMobileNoDataGridViewTextBoxColumn.Name = "alternateMobileNoDataGridViewTextBoxColumn";
            this.alternateMobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aadharNoDataGridViewTextBoxColumn
            // 
            this.aadharNoDataGridViewTextBoxColumn.DataPropertyName = "Aadhar_No";
            this.aadharNoDataGridViewTextBoxColumn.HeaderText = "Aadhar_No";
            this.aadharNoDataGridViewTextBoxColumn.Name = "aadharNoDataGridViewTextBoxColumn";
            this.aadharNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pANNoDataGridViewTextBoxColumn
            // 
            this.pANNoDataGridViewTextBoxColumn.DataPropertyName = "PAN_No";
            this.pANNoDataGridViewTextBoxColumn.HeaderText = "PAN_No";
            this.pANNoDataGridViewTextBoxColumn.Name = "pANNoDataGridViewTextBoxColumn";
            this.pANNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenceNoDataGridViewTextBoxColumn
            // 
            this.licenceNoDataGridViewTextBoxColumn.DataPropertyName = "Licence_No";
            this.licenceNoDataGridViewTextBoxColumn.HeaderText = "Licence_No";
            this.licenceNoDataGridViewTextBoxColumn.Name = "licenceNoDataGridViewTextBoxColumn";
            this.licenceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            this.emailIdDataGridViewTextBoxColumn.DataPropertyName = "Email_Id";
            this.emailIdDataGridViewTextBoxColumn.HeaderText = "Email_Id";
            this.emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            this.emailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "Charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            this.chargesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverDetailsBindingSource
            // 
            this.driverDetailsBindingSource.DataMember = "Driver_Details";
            this.driverDetailsBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet";
            this.dB_OLA_CAB_Mgt_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driver_DetailsTableAdapter
            // 
            this.driver_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_Driver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_View_Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Driver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Driver_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Driver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_View_Driver;
        private DB_OLA_CAB_Mgt_SystemDataSet dB_OLA_CAB_Mgt_SystemDataSet;
        private System.Windows.Forms.BindingSource driverDetailsBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSetTableAdapters.Driver_DetailsTableAdapter driver_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pANNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
    }
}