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
            
            // Insert  Admin's permission Enum values to the combo box
            cmb_permissions.DataSource = Enum.GetValues(typeof(Administrator.Permissions));
        }

        #region Event handlers
        private void btn_createNewAcc_Click(object sender, EventArgs e)
        {
            var username = txt_newAccName.Text;
            var password = txt_newAccPassword.Text;
            var reEnteredPassword = txt_newAccReEnteredPassword.Text;
            var permission = cmb_permissions.SelectedValue.ToString();

            // validate the new account 
            if (!ValidateNewAccountInput(username, password, reEnteredPassword))
            {
                return;
            }

            // Check if username already exists or not
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

            if (!IsAcccountRemoveable(txt_deleteAccUsername.Text,txt_deleteAccPassword.Text))
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

        private bool IsAcccountRemoveable(string username,string password)
        {
            // Search the user account that is going to be deleted and check its permission
            var account = _adminService.Search(username, password);

            // if the account not find, exit the function
            if (account.Count <= 0)
            {
                return false;
            }

            // Check the account has "CanReadnWrite" permission, return FALSE if it does not have "CanReadnWrite" permission
            var permission = account[0]["Permission"].ToString();
            if (permission != Administrator.Permissions.CanReadnWrite.ToString())
            {
                return true;
            }

            // If the account has "CanReadnWrite" permission, check whether that account is the last account that has "CanReadnWrite" permission.
            var admins = _adminService.GetAll();

            // Filter account with "CanReadnWrite" permission
            var filteredDataTable = admins.Where(a => a.permission == Administrator.Permissions.CanReadnWrite.ToString()).ToList();

            // If the account the last one that has "CanReadnWrite" permission, denied the user request to delete the account.
            if (filteredDataTable.Count == 1)
            {
                OutputMessage.WarningMessage("There must be atleast one admin account that has \"CanReadnWrite\" permission.");
                return false;
            }

            return true;
        }

        private bool ValidateNewAccountInput(string username, string password, string reEnteredPassword)
        {
            // Check rhecurrent logged in user permission
            if (Session.CurrentSession.LoggedInAdmin.Permission != Administrator.Permissions.CanReadnWrite.ToString())
            {
                lbl_accountOperationsStatus.Text = "You don't have permission to do this action !";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
                return false;
            }

            // Check for Null or Empty inputs
            if (string.IsNullOrEmpty(username))
            {
                OutputMessage.WarningMessage("\"Username\" input cannot be empty. Please enter values into the input.");
                txt_newAccName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                OutputMessage.WarningMessage("\"Password\" input cannot be empty. Please enter values into the input.");
                txt_newAccName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(reEnteredPassword))
            {
                OutputMessage.WarningMessage("\"Re-Entered\" input cannot be empty. Please enter values into the input.");
                txt_newAccName.Focus();
                return false;
            }

            // Exit the funtion if two passwords are not identical
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
            txt_deleteAccPassword.Text = string.Empty;
            txt_deleteAccUsername.Text = string.Empty;
            txt_newAccName.Text = string.Empty;
            txt_newAccPassword.Text = string.Empty;
            txt_newAccReEnteredPassword.Text = string.Empty;
        }
        #endregion
    }
}
