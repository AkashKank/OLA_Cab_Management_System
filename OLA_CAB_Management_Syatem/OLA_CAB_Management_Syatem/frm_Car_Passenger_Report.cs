using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_Car_Passenger_Report : Form
    {
        ReportDocument rd = new ReportDocument();

        public frm_Car_Passenger_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_OLA_CAB_Mgt_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Car_Passenger_Report_Load(object sender, EventArgs e)
        {
            string sqlStr = "Select Passenger_Id,Name,Mobile_No,Area,Charges from Passenger_Car_Details";

            SqlDataAdapter da = new SqlDataAdapter(sqlStr, Con);

            DataSet ds = new DataSet();

            da.Fill(ds, "Passenger_Car_Details");

            CarPassenger_CrystalReport cr = new CarPassenger_CrystalReport();
            cr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = cr;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            frm_MDI_OlaCab LF = new frm_MDI_OlaCab();
            LF.Show();
            this.Hide();
        }

    }
}
