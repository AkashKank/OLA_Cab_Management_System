﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_View_Bike_Passenger : Form
    {
        public frm_View_Bike_Passenger()
        {
            InitializeComponent();
        }

        private void frm_View_Bike_Passenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_OLA_CAB_Mgt_SystemDataSet3.Passenger_Bike_Details' table. You can move, or remove it, as needed.
            this.passenger_Bike_DetailsTableAdapter.Fill(this.dB_OLA_CAB_Mgt_SystemDataSet3.Passenger_Bike_Details);

        }
    }
}
