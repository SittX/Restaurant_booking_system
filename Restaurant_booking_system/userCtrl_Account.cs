using Restaurant_booking_system.DataAccess;
using Restaurant_booking_system.Interfaces;
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

        private ICustomerDataAccess _dataAccess;
        public userCtrl_Account()
        {
            InitializeComponent();
            _dataAccess = new CustomerDataAccess();
        }

        private void userCtrl_Account_Load(object sender, EventArgs e)
        {
            txt_fname.Text = SessionInfo.LoggedInUser.Firstname;
            txt_lname.Text = SessionInfo.LoggedInUser.Lastname;
            txt_email.Text = SessionInfo.LoggedInUser.Email;
            txt_username.Text = SessionInfo.LoggedInUser.Username;
        }

        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            // Check if the password textbox is null or not
            if (!string.IsNullOrEmpty(txt_newPassword.Text))
            {
                var oldPassword = txt_oldPassword.Text;
                var newPassword = txt_newPassword.Text;
                
                // Check if the operations is success or not
                if(_dataAccess.UpdatePassword(newPassword, oldPassword, txt_username.Text))
                {
                    lbl_operationsStatus.Text = "Updated password";
                    lbl_operationsStatus.ForeColor = Color.Green;
                    ReloadInfo();
                }
                
            }
        }

    
        private void btn_updateUsername_Click(object sender, EventArgs e)
        {
            var newUsername = txt_newUsername.Text;
            var oldUsername = txt_username.Text;
            if (_dataAccess.UpdateUsername(newUsername, oldUsername, SessionInfo.LoggedInUser.Password))
            {
                lbl_operationsStatus.Text = "Updated Username";
                lbl_operationsStatus.ForeColor = Color.Green;
                ReloadInfo();
            }
        }

        private void ReloadInfo()
        {
            var data = _dataAccess.SearchById(SessionInfo.LoggedInUser.Id);
            if(data.Count()> 0)
            {
                SessionInfo.LoggedInUser = new Models.User()
                {
                    Id = Convert.ToInt32(data[0][0].ToString()),
                    Firstname = data[0][1].ToString(),
                    Lastname = data[0][2].ToString(),
                    Username = data[0][3].ToString(),
                    Password = data[0][4].ToString(),
                    Email = data[0][5].ToString()
                };
                userCtrl_Account_Load(this,EventArgs.Empty);
            }
        }



    }
}
