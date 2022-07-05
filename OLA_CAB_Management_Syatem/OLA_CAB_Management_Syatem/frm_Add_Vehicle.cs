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
    public partial class frm_Add_Vehicle : Form
    {
        public frm_Add_Vehicle()
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

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Vehicle_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Vehicle_ID) from Vehicle_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Vehicle_Id.Text = Convert.ToString(Auto_Increament_ID());
            cmb_Vehicle_Type.SelectedIndex = -1;
            tb_Name.Clear();
            tb_Owner_Name.Clear();
            tb_Vehicle_No.Clear();
        }
        private void frm_Add_Vehicle_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_Vehicle_Type.Text != "" && tb_Name.Text != "" && tb_Owner_Name.Text != "" && tb_Vehicle_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Vehicle_Details(Vehicle_Id,Vehicle_Name,Vehicle_No,Owner_Name,Vehicle_Type) VALUES (@id,@v_name,@no,@o_name,@type)";

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_Vehicle_Id.Text;
                Cmd.Parameters.Add("v_name", SqlDbType.NVarChar).Value = cmb_Vehicle_Type.Text;
                Cmd.Parameters.Add("no", SqlDbType.NVarChar).Value = tb_Vehicle_No.Text;
                Cmd.Parameters.Add("o_name", SqlDbType.NVarChar).Value = tb_Owner_Name.Text;
                Cmd.Parameters.Add("type", SqlDbType.NVarChar).Value = cmb_Vehicle_Type.Text;
                //Cmd.Parameters.Add("date", SqlDbType.Date).Value = dtp_Date.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Vehicle Details Saved Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        
    }
}
