using Restaurant_booking_system.DataAccess;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System;
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
    public partial class userCtrl_AdminAccount : UserControl
    {
        private IAdminDataccess _dataAccess;
        public userCtrl_AdminAccount()
        {
            InitializeComponent();
            _dataAccess = new AdminDataccess();
        }

        private void userCtrl_AdminAccount_Load(object sender, EventArgs e)
        {
            var data =  _dataAccess.GetAll();
            if(data is not null)
            {
                dataGridView_adminAccounts.DataSource = data;
            }
            
        }

        private void btn_createNewAcc_Click(object sender, EventArgs e)
        {
            // Check for Null or Empty inputs
            if(!string.IsNullOrEmpty(txt_newAccPassword.Text) && !string.IsNullOrEmpty(txt_newAccPassword.Text))
            {
                var newAccount = new Administrator() { Username = txt_newAccName.Text, Password = txt_newAccPassword.Text };

                // Check if the account creation is successful or not
                if (!_dataAccess.Insert(newAccount))
                {
                    MessageBox.Show("Please try again");
                }
            }
            else
            {
                MessageBox.Show("inputs can't be empty");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dataGridView_adminAccounts.DataSource = _dataAccess.GetAll();
        }

        private void btn_cancelNewAcc_Click(object sender, EventArgs e)
        {
            txt_newAccName.Text = null;
            txt_newAccPassword.Text = null;
        }

        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            _dataAccess.Delete(Convert.ToInt32(txt_deleteAccName.Text), txt_deleteAccPassword.Text);
        }
    }
}
