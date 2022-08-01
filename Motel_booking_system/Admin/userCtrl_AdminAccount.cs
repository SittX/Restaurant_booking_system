using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using Motel_booking_system.Models;



namespace Motel_booking_system.Admin
{
    public partial class userCtrl_AdminAccount : UserControl
    {
        private IAdminService _adminService;
        public userCtrl_AdminAccount(IAdminService adminService)
        {
            InitializeComponent();
            _adminService = adminService;
        }

        private void userCtrl_AdminAccount_Load(object sender, EventArgs e)
        {
            dataGridView_adminAccounts.DataSource = _adminService.GetAll();
            cmb_permissions.DataSource = Enum.GetValues(typeof(Administrator.Permissions));
        }

        #region Event handlers
        private void btn_createNewAcc_Click(object sender, EventArgs e)
        {
            var username = txt_newAccName.Text;
            var password = txt_newAccPassword.Text;
            var reEnteredPassword = txt_newAccReEnteredPassword.Text;
            var permission = cmb_permissions.SelectedValue.ToString();

            // valid new account 
            if (!ValidateNewAccountInput(username, password, reEnteredPassword))
            {
                return;
            }

            // Check if duplicate username
            if (!_adminService.CheckDuplicateUsername(username))
            {
                return;
            }

            // Create new admin object and insert into database
            var newAccount = new Administrator()
            {
                Id = Administrator.GenerateId(_adminService.GetAll()),
                Username = username,
                Password = password,
                Permission = permission
            };


            // Check if the account creation is successful or not
            if (!_adminService.Insert(newAccount))
            {
                return;
            }

            ClearInputs();

            lbl_accountOperationsStatus.Text = "New user account has been successfully created. \nReload the table to see the account.";
            lbl_accountOperationsStatus.ForeColor = Color.Green;

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dataGridView_adminAccounts.DataSource = _adminService.GetAll();
        }

        private void btn_cancelNewAcc_Click(object sender, EventArgs e)
        {
            txt_newAccName.Text = null;
            txt_newAccPassword.Text = null;
            ClearInputs();
        }

        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_deleteAccUsername))
            {
                return;
            }
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_deleteAccPassword))
            {
                return;
            }

            if (MessageBox.Show($"Are you sure to delete the entered account ?", "Account deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            {
                return;
            }

            if (Session.CurrentSession.LoggedInAdmin.Permission != Administrator.Permissions.CanReadnWrite.ToString())
            {
                lbl_accountOperationsStatus.Text = "You don't have permission to do this action !";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
                return;
            }


            if (!_adminService.Delete(txt_deleteAccUsername.Text, txt_deleteAccPassword.Text))
            {
                lbl_accountOperationsStatus.Text = "Account cannot be deleted";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
            }

            lbl_accountOperationsStatus.Text = "Account has been deleted.";
            lbl_accountOperationsStatus.ForeColor = Color.Green;
            ClearInputs();

        }
        #endregion

        #region Methods
        private bool ValidateNewAccountInput(string username, string password, string reEnteredPassword)
        {
            // Check for Null or Empty inputs
            if (string.IsNullOrEmpty(username))
            {
                OutputMessage.WarningMessage("Input values cannot be empty. Please check your inputs.");
                txt_newAccName.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(password))
            {
                OutputMessage.WarningMessage("Input values cannot be empty. Please check your inputs.");
                txt_newAccName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(reEnteredPassword))
            {
                OutputMessage.WarningMessage("Input values cannot be empty. Please check your inputs.");
                txt_newAccName.Focus();
                return false;
            }

            // Check current logged in user permission
            if (Session.CurrentSession.LoggedInAdmin.Permission != Administrator.Permissions.CanReadnWrite.ToString())
            {
                lbl_accountOperationsStatus.Text = "You don't have permission to do this action !";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
                return false;
            }

            // Break causes if two passwords are not identical
            if (password != reEnteredPassword)
            {
                lbl_accountOperationsStatus.Text = "Passwords are not identical.";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txt_deleteAccPassword.Text = String.Empty;
            txt_deleteAccUsername.Text = String.Empty;
            txt_newAccName.Text = String.Empty;
            txt_newAccPassword.Text = String.Empty;
            txt_newAccReEnteredPassword.Text = String.Empty;
        }
        #endregion
    }
}
