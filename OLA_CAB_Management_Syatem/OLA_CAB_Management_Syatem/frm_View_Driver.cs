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
    public partial class frm_View_Driver : Form
    {
        public frm_View_Driver()
        {
            InitializeComponent();
        }

        private void frm_View_Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_OLA_CAB_Mgt_SystemDataSet.Driver_Details' table. You can move, or remove it, as needed.
            this.driver_DetailsTableAdapter.Fill(this.dB_OLA_CAB_Mgt_SystemDataSet.Driver_Details);

        }
    }
}
