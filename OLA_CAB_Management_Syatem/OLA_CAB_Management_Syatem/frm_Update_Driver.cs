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
    public partial class frm_Update_Driver : Form
    {
        public frm_Update_Driver()
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
        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Age.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Email_ID.Clear();
            tb_Address.Clear();
            tb_Experience.Clear();
            tb_Charges.Clear();
            tb_Driver_ID.Clear();

            tb_Name.Focus();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (tb_Driver_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select Driver_Name,Age,Mobile_No,Alternate_Mobile_No,Email_id,Address,Experience,Charges from Driver_Details where Driver_Id = " + tb_Driver_ID.Text + "";

                var Obj = Cmd.ExecuteReader();
                //SqlDataReader Obj = Cmd.EndExecuteReader();

                if (Obj.Read())
                {
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Driver_Name"));
                    tb_Age.Text = Obj["Age"].ToString();
                    tb_Mobile_No.Text = Obj["Mobile_No"].ToString();
                    tb_Alternate_Mobile_No.Text = Obj["Alternate_Mobile_No"].ToString();
                    tb_Email_ID.Text = Obj.GetString(Obj.GetOrdinal("Email_id"));
                    tb_Address.Text = Obj.GetString(Obj.GetOrdinal("Address"));
                    tb_Experience.Text = Obj.GetString(Obj.GetOrdinal("Experience"));
                    tb_Charges.Text = Obj["Charges"].ToString();


                    btn_Update.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Information is Not Available.....", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Clear_Controls();

                }
                Con_Close();
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Name.Text != "" && tb_Age.Text != "" && tb_Mobile_No.Text != "" && tb_Alternate_Mobile_No.Text != "" && tb_Email_ID.Text != "" && tb_Address.Text != "" && tb_Experience.Text != "" && tb_Charges.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Update Driver_Details set Driver_Name = @Name, Age = @Age, Mobile_No = @Mob_No, Alternate_Mobile_No = @Alt_Mob_No, Email_id  = @Email_id, Address = @Address, Experience = @Experience, Charges = @Charges where Driver_Id = " + tb_Driver_ID.Text + "";


                cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Age", SqlDbType.Int).Value = tb_Age.Text;
                cmd.Parameters.Add("Mob_No", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Alt_Mob_No", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                cmd.Parameters.Add("Email_id", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("Experience", SqlDbType.NVarChar).Value = tb_Experience.Text;
                cmd.Parameters.Add("Charges", SqlDbType.Float).Value = tb_Charges.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Driver Update Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

                btn_Search.Enabled = true;
                btn_Update.Enabled = false;
            }
            else
            {
                MessageBox.Show("first Fill All Field", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
