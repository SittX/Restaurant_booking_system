﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_booking_system.Admin
{
    public partial class userCtrl_adminReservations : UserControl
    {
        public userCtrl_adminReservations()
        {
            InitializeComponent();
        }

        private void btn_makeReservation_Click(object sender, EventArgs e)
        {
            Form reservationFrm = new Frm_AdminAddReservation();
            reservationFrm.Show();
        }
    }
}
