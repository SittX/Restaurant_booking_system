using Restaurant_booking_system.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_booking_system
{
    public partial class userCtrl_Account : UserControl
    {
        public userCtrl_Account()
        {
            InitializeComponent();
        }

        private void userCtrl_Account_Load(object sender, EventArgs e)
        {
            txt_fname.Text = SessionInfo.LoggedInUser.Firstname;
            txt_lname.Text = SessionInfo.LoggedInUser.Lastname;
            txt_email.Text = SessionInfo.LoggedInUser.Email;
            txt_username.Text = SessionInfo.LoggedInUser.Username;
        }
    }
}
