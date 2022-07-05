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
    public partial class frm_Add_Driver : Form
    {
        public frm_Add_Driver()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_OLA_CAB_Mgt_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {

            tb_Driver_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Name.Clear();
            tb_Age.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Aadhar_No.Clear();
            tb_Pan_No.Clear();
            tb_Licence_No.Clear();
            tb_Email_ID.Clear();
            tb_Experience.Clear();
            tb_Address.Clear();
            tb_Charges.Clear();

            tb_Driver_ID.Focus();

        }

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Driver_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Driver_ID) from Driver_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        private void frm_Add_Driver_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            Con_Open();
            if (tb_Driver_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Aadhar_No.Text != "" && tb_Pan_No.Text != "" && tb_Age.Text != "" && tb_Licence_No.Text != "" && tb_Charges.Text != "" && tb_Address.Text != "" && tb_Experience.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert Into Driver_Details(Driver_Id,Driver_Name,Age,Mobile_No,Alternate_Mobile_No,Aadhar_No,PAN_No,Licence_No,Email_id,Address,Experience,Charges) Values(@ID,@Name,@Age,@Mobile_No,@Alternate_Mobile_No,@Aadhar_No,@Pan_No,@Licence_No,@Email_id,@Address,@Experience,@Charges)";
                cmd.Connection = Con;

                cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Driver_ID.Text;
                cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Age", SqlDbType.Int).Value = tb_Age.Text;
                cmd.Parameters.Add("Mobile_No", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Alternate_Mobile_No", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                cmd.Parameters.Add("Aadhar_No", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                cmd.Parameters.Add("Pan_No", SqlDbType.NVarChar).Value = tb_Pan_No.Text;
                cmd.Parameters.Add("Licence_No", SqlDbType.NVarChar).Value = tb_Licence_No.Text;
                cmd.Parameters.Add("Email_id", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("Experience", SqlDbType.NVarChar).Value = tb_Experience.Text;
                cmd.Parameters.Add("Charges", SqlDbType.Float).Value = tb_Charges.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Driver Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Field", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Only_Numerics(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
