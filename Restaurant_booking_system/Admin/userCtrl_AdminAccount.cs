using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Repositories;



namespace Restaurant_booking_system.Admin
{
    /// <summary>
    /// Admin dashboard needs some UI to indicate account has been created or not.
    /// It also needs extra textbox to double check the new user account password
    /// The buttons can be a little bit smaller
    /// </summary>
    public partial class userCtrl_AdminAccount : UserControl
    {
        private IAdminRepository _dataAccess;
        public userCtrl_AdminAccount()
        {
            InitializeComponent();
            _dataAccess = new AdminRepository(new BookingDataSetTableAdapters.adminTableAdapter());
        }

        private void userCtrl_AdminAccount_Load(object sender, EventArgs e)
        {
            dataGridView_adminAccounts.DataSource = _dataAccess.GetAll();
            
            foreach(var permission in Enum.GetValues(typeof(Administrator.Permissions)))
            {
                cmb_permissions.Items.Add((int)permission);
            }
            
        }

        // This function need to be refactored
        private void btn_createNewAcc_Click(object sender, EventArgs e)
        {
            var username = txt_newAccName.Text;
            var password = txt_newAccPassword.Text;
            var reEnteredPassword = txt_newAccReEnteredPassword.Text;
            var permissions = cmb_permissions.SelectedValue.ToString();
            MessageBox.Show(cmb_permissions.SelectedValue.ToString());
            //var permission = Enum.GetValues(Admin.);
            // Check for Null or Empty inputs
            if (!string.IsNullOrEmpty(username)
                && !string.IsNullOrEmpty(password)
                && !string.IsNullOrEmpty(reEnteredPassword))
            {
                // Check if both of the two password inputs are identical
                if (password == reEnteredPassword)
                {
                    var newAccount = new Administrator()
                    {
                        Id = Administrator.GenerateId(_dataAccess.GetAll()),
                        Username = username,
                        Password = password
                    };
                    

                    // Check if the account creation is successful or not
                    if (_dataAccess.Insert(newAccount))
                    {
                        lbl_accountOperationsStatus.Text = "New user account has been successfully created. \nReload the table to see the account.";
                        lbl_accountOperationsStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show("User cannot be created. Try again later.");
                    }
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
            if (_dataAccess.Delete(txt_deleteAccUsername.Text, txt_deleteAccPassword.Text))
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
