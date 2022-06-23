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
    /// <summary>
    /// Admin dashboard needs some UI to indicate account has been created or not.
    /// It also needs extra textbox to double check the new user account password
    /// The buttons can be a little bit smaller
    /// </summary>
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
            dataGridView_adminAccounts.DataSource =  _dataAccess.GetAll();
        }

        private void btn_createNewAcc_Click(object sender, EventArgs e)
        {
            // Check for Null or Empty inputs
            if(!string.IsNullOrEmpty(txt_newAccPassword.Text)
                && !string.IsNullOrEmpty(txt_newAccPassword.Text)
                && !string.IsNullOrEmpty(txt_newAccReEnteredPassword.Text))
            {
                // Check if both of the two password inputs are identical
                if(txt_newAccPassword.Text == txt_newAccReEnteredPassword.Text)
                {
                    var newAccount = new Administrator() { Username = txt_newAccName.Text, Password = txt_newAccPassword.Text };
                    
                    // Check if the account creation is successful or not
                    if (!_dataAccess.Insert(newAccount))
                    {
                        MessageBox.Show("User cannot be created. Try again later.");
                    }
                    lbl_accountOperationsStatus.Text = "New user account has been successfully created. \nReload the table to see the account.";
                    lbl_accountOperationsStatus.ForeColor = Color.Green;
                }
                else
                {
                    lbl_accountOperationsStatus.Text = "Passwords are not identical.";
                    lbl_accountOperationsStatus.ForeColor = Color.Red;
                }

            }
            else
            {
                MessageBox.Show("Inputs can't be empty");
                txt_newAccName.Focus();
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
            if(_dataAccess.Delete(Convert.ToInt32(txt_deleteAccId.Text), txt_deleteAccPassword.Text))
            {
                lbl_accountOperationsStatus.Text = "Account has been deleted.";
                lbl_accountOperationsStatus.ForeColor = Color.Green;
            }
            else
            {
                lbl_accountOperationsStatus.Text = "Account cannot be deleted";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
            }
        }
    }
}
