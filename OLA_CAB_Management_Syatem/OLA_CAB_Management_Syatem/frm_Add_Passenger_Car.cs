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
    public partial class frm_Add_Passenger_Car : Form
    {
        public frm_Add_Passenger_Car()
        {
            InitializeComponent();
        }


        double charg, km;
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

        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From Passenger_Car_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Passenger_Id) From Passenger_Car_Details";

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
            tb_PassengerID.Text = Convert.ToString(Auto_Increment());
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            tb_LicenceNo.Clear();
            tb_Email_ID.Clear();
            cmb_Driver_Name.SelectedIndex = -1;
            tb_Charges.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Address.Clear();
            tb_Aadhar_No.Clear();
            cmb_Area.SelectedIndex = -1;


           
            charg = 0;
            km = 0;

            tb_Name.Focus();
        }



        void Bind_Area()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Area_Name) from Area_Detail";

            SqlDataReader sdr = Cmd.ExecuteReader();

            while (sdr.Read())
            {
                cmb_Area.Items.Add(sdr.GetString(sdr.GetOrdinal("Area_Name")));
            }

            Cmd.Dispose();
            sdr.Dispose();

            Con_Close();
        }

        void Bind_Charges()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Km,Car_Km_Price from Area_Detail where Area_Name = '" + cmb_Area.Text + "'";

            SqlDataReader sdr = Cmd.ExecuteReader();

            while (sdr.Read())
            {
                charg = Convert.ToDouble(sdr["Car_Km_Price"].ToString());
                km = Convert.ToDouble(sdr["Km"].ToString());

                tb_Charges.Text = (charg * km).ToString();
            }

            Cmd.Dispose();
            sdr.Dispose();


            Con_Close();
        }


        void Bind_Driver()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Driver_Name) from Driver_Details";

            SqlDataReader sdr = Cmd.ExecuteReader();

            while (sdr.Read())
            {
                cmb_Driver_Name.Items.Add(sdr.GetString(sdr.GetOrdinal("Driver_Name")));
            }

            Cmd.Dispose();
            sdr.Dispose();

            Con_Close();
        }

        private void frm_Add_Passenger_Car_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Bind_Area();
            Bind_Driver();
        }

        private void cmb_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Charges();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Aadhar_No.Text != "" && tb_Address.Text != "" && tb_Charges.Text != "" && cmb_Driver_Name.Text != "" && tb_LicenceNo.Text != "" && tb_Mobile_No.Text != "" && tb_Name.Text != "" && cmb_Area.Text != "")
            {

                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Passenger_Car_Details(Passenger_Id,Name,Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,Licence_No,Email_Id,Address,Driver_Name,Area,Charges)values(@id,@name,@date,@mobno,@alternateno,@aadhar,@licence,@email,@address,@driver,@area,@charges)";

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_PassengerID.Text;
                Cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("mobno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("aadhar", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("licence", SqlDbType.NVarChar).Value = tb_LicenceNo.Text;
                Cmd.Parameters.Add("address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("driver", SqlDbType.NVarChar).Value = cmb_Driver_Name.Text;
                Cmd.Parameters.Add("area", SqlDbType.NVarChar).Value = cmb_Area.Text;
                Cmd.Parameters.Add("charges", SqlDbType.Float).Value = tb_Charges.Text;

                if (tb_Alternate_Mobile_No.Text != "")
                {
                    Cmd.Parameters.Add("alternateno", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                }
                else
                {
                    Cmd.Parameters.Add("alternateno", SqlDbType.Decimal).Value = "0";
                }

                if (tb_Email_ID.Text != "")
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                }
                else
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = "Annonymous";
                }


                if (Convert.ToInt32(tb_Mobile_No.TextLength) > 0 && Convert.ToInt32(tb_Mobile_No.TextLength) < 10)
                {
                    MessageBox.Show("Mobile Number Should Have 10 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                else if (Convert.ToInt32(tb_Aadhar_No.TextLength) > 0 && Convert.ToInt32(tb_Aadhar_No.TextLength) < 12)
                {
                    MessageBox.Show("Aadhar Number Should Have 12 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                else
                {
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("New Car Passenger Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }
                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void dtp_Date_ValueChanged_1(object sender, EventArgs e)
        {
            dtp_Date.MinDate = dtp_Date.MaxDate = DateTime.Now;
        }


    }
}
