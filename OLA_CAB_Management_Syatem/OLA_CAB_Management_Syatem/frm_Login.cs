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
    public partial class frm_Login : Form
    {
        public frm_Login()
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
        private void btn_SingIn_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Login_Details Where Username = @UName And Password = @Pass";

            Cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if (Ret == tb_Username.Text && tb_Username.Text != "")
            {
                Global_Vars.Uname = tb_Username.Text;

                if (tb_Username.Text == "Admin")
                {
                    Global_Vars.User_Role = 1;
                }

                MessageBox.Show(" Login Successful...!! ", "Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_MDI_OlaCab mo = new frm_MDI_OlaCab();
                mo.Show();
                this.Hide();


            }

            else
            {

                MessageBox.Show(" Please Check Username or Password ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_SingIn.Enabled = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
