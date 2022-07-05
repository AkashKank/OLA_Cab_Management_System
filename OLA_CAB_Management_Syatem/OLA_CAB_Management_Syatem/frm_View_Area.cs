using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_View_Area : Form
    {
        public frm_View_Area()
        {
            InitializeComponent();
        }

        private void frm_View_Area_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_OLA_CAB_Mgt_SystemDataSet5.Area_Detail' table. You can move, or remove it, as needed.
            this.area_DetailTableAdapter.Fill(this.dB_OLA_CAB_Mgt_SystemDataSet5.Area_Detail);
            // TODO: This line of code loads data into the 'dB_OLA_CAB_Mgt_SystemDataSet2.Area_Details' table. You can move, or remove it, as needed.
            //this.Area_DetailTableAdapter.Fill(this.dB_OLA_CAB_Mgt_SystemDataSet2.Area_Detail);

        }
    }
}
