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
    public partial class frm_MDI_OlaCab : Form
    {
        public frm_MDI_OlaCab()
        {
            InitializeComponent();
        }

        private void bikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Add_Passenger ap = new frm_Add_Passenger();

            ap.MdiParent = this;

            ap.WindowState = FormWindowState.Maximized;

            ap.Show();
        }

        private void addVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Add_Vehicle av = new frm_Add_Vehicle();

            av.MdiParent = this;

            av.WindowState = FormWindowState.Maximized;

            av.Show();
        }

        private void viewVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_View_Vehicle vv = new frm_View_Vehicle();

            vv.MdiParent = this;

            vv.WindowState = FormWindowState.Maximized;

            vv.Show();
        }

        private void updateDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Update_Driver ur = new frm_Update_Driver();

            ur.MdiParent = this;

            ur.WindowState = FormWindowState.Maximized;

            ur.Show();
        }

        private void viewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_View_Driver vd = new frm_View_Driver();

            vd.MdiParent = this;

            vd.WindowState = FormWindowState.Maximized;

            vd.Show();
        }

        private void addAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Add_Area aa = new frm_Add_Area();

            aa.MdiParent = this;

            aa.WindowState = FormWindowState.Maximized;

            aa.Show();
        }

        private void updateAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Update_Area ua = new frm_Update_Area();

            ua.MdiParent = this;

            ua.WindowState = FormWindowState.Maximized;

            ua.Show();
        }

        private void viewAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_View_Area va = new frm_View_Area();

            va.MdiParent = this;

            va.WindowState = FormWindowState.Maximized;

            va.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Add_User au = new frm_Add_User();

            au.MdiParent = this;

            au.WindowState = FormWindowState.Maximized;

            au.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Update_User uu = new frm_Update_User();

            uu.MdiParent = this;

            uu.WindowState = FormWindowState.Maximized;

            uu.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Delete_User du = new frm_Delete_User();

            du.MdiParent = this;

            du.WindowState = FormWindowState.Maximized;

            du.Show();
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Add_Driver ad = new frm_Add_Driver();

            ad.MdiParent = this;

            ad.WindowState = FormWindowState.Maximized;

            ad.Show();
        }

        private void bikeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_View_Bike_Passenger vbp = new frm_View_Bike_Passenger();

            vbp.MdiParent = this;

            vbp.WindowState = FormWindowState.Maximized;

            vbp.Show();
        }

        private void carToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_View_Car_Passenger vcp = new frm_View_Car_Passenger();

            vcp.MdiParent = this;

            vcp.WindowState = FormWindowState.Maximized;

            vcp.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Back_Slider.Hide();

            frm_Add_Passenger_Car acp = new frm_Add_Passenger_Car();

            acp.MdiParent = this;

            acp.WindowState = FormWindowState.Maximized;

            acp.Show();
        }

        private void frm_MDI_OlaCab_Load(object sender, EventArgs e)
        {
            lbl_User_Logged_In.Text = Global_Vars.Uname;

            if (Global_Vars.User_Role == 1)
            {
                customerToolStripMenuItem.Visible = true;
                vehicalToolStripMenuItem.Visible = true;
                driverToolStripMenuItem.Visible = true;
                areaToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
                userManagementToolStripMenuItem.Visible = true;
            }
            else
            {
                customerToolStripMenuItem.Visible = true;
                vehicalToolStripMenuItem.Visible = true;
                driverToolStripMenuItem.Visible = true;
                areaToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;

                updateAreaToolStripMenuItem.Visible = false;
                updateDriverToolStripMenuItem.Visible = false;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                customerToolStripMenuItem.Visible = false;
                vehicalToolStripMenuItem.Visible = false;
                driverDetailsToolStripMenuItem.Visible = false;
                areaToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;

                Global_Vars.User_Role = 0;

                frm_Login LF = new frm_Login();

                LF.Show();

                this.Hide();
            }
        }

        private int imageNumber = 1;

        private void Load_NextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }

            pb_Slider.ImageLocation = string.Format(@"Slider_Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Load_NextImage();
        }

        private void bIkePassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Bike_Passenger_Report obj = new frm_Bike_Passenger_Report();
            this.Hide();
            obj.Show();
        }

        private void carPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Car_Passenger_Report CP = new frm_Car_Passenger_Report();
            this.Hide();
            CP.Show();
        }

        private void vehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vehicle_Report VR = new frm_Vehicle_Report();
            VR.Show();
            this.Hide();
        }

        private void driverDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Driver_Report DR = new frm_Driver_Report(); 
            DR.Show();
            this.Hide();
        }

        private void areaDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Area_Report AR = new frm_Area_Report();
            AR.Show();
            this.Hide();
        }


       

    }
}
