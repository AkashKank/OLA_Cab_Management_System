using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_Add_Area : Form
    {
        public frm_Add_Area()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DB_OLA_CAB_Mgt_System;Integrated Security=True");

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

        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (Area_Id) From Area_Detail";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Area_Id) from Area_Detail";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Cmd.Dispose();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Area_Id.Text = Convert.ToString(Auto_Increment());
            tb_Name.Text = "";
            tb_kilometer.Text = "";
            tb_Bike_Price.Text = "";
            tb_Car_Price.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (tb_Area_Id.Text != "" && tb_Name.Text != "" && tb_kilometer.Text != "" && tb_Bike_Price.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Area_Detail(Area_Id,Area_Name,Km,Bike_Km_Price,Car_Km_Price) Values(@A_ID,@A_Name,@Km,@Bike_Price,@Car_Price)";

                Cmd.Parameters.Add("A_ID", SqlDbType.Int).Value = tb_Area_Id.Text;
                Cmd.Parameters.Add("A_Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Km", SqlDbType.Float).Value = tb_kilometer.Text;
                Cmd.Parameters.Add("Bike_Price", SqlDbType.Float).Value = tb_Bike_Price.Text;
                Cmd.Parameters.Add("Car_Price", SqlDbType.Float).Value = tb_Car_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Area Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_Area_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
