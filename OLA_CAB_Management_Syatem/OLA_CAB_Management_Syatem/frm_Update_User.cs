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
    public partial class frm_Update_User : Form
    {
        public frm_Update_User()
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

        void Clear_Controls()
        {
            cmb_Username.SelectedIndex = -1;
            tb_Current_Password.Clear();
            tb_New_Password.Clear();

            cmb_Username.Focus();
        }

        void Bind_Username_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Username) from Login_Details";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();
            Con_Close();
        }

        private void frm_Update_User_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Bind_Username_To_Combobox();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_Username.Text != "" && tb_Current_Password.Text != "" && tb_New_Password.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * from Login_Details where Username = '" + cmb_Username.Text + "'", Con);
                var Obj = Cmd.ExecuteReader();

                string Pass = "";

                if (Obj.Read())
                {
                    Pass = Obj.GetString(Obj.GetOrdinal("Password"));
                }

                Obj.Dispose();
                Cmd.Dispose();

                if (tb_Current_Password.Text == Pass)
                {
                    SqlCommand Cmd1 = new SqlCommand();

                    Cmd1.Connection = Con;

                    Cmd1.CommandText = "Update Login_Details set Password = '" + tb_New_Password.Text + "' Where Username = '" + cmb_Username.Text + "'";

                    Cmd1.ExecuteNonQuery();

                    MessageBox.Show("Password Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }

                else
                {
                    MessageBox.Show("Password Didn't Match!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
