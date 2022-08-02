using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using Motel_booking_system.Services;
namespace Motel_booking_system
{
    public partial class userCtrl_Account : UserControl
    {
        private string? username, email, password;

        private ICustomerService _customerService;
        public userCtrl_Account(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        #region Event handlers
        private void userCtrl_Account_Load(object sender, EventArgs e)
        {
            PopulateInputs();
        }

        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            // Check if the inputs are empty or have null value
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_newPassword)) return;
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_oldPassword)) return;

            var oldPassword = txt_oldPassword.Text;
            var newPassword = txt_newPassword.Text;

            // Check if the operations is success or not
            if (_customerService.UpdatePassword(newPassword, oldPassword, Session.CurrentSession.LoggedInUser.Id))
            {
                lbl_operationsStatus.Text = "Updated password";
                lbl_operationsStatus.ForeColor = Color.Green;
                ReloadInfo();
            }

            txt_newPassword.Text = string.Empty;
            txt_oldPassword.Text = string.Empty;
        }

        private void btn_createNewAccount_Click(object sender, EventArgs e)
        {
            Form userRegisteration = new Frm_userRegisteration(new CustomerService());
            userRegisteration.Show();
        }

        private void btn_updateUsername_Click(object sender, EventArgs e)
        {
            // Check if the inputs are empty or have null value
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_newUsername)) return;

            var newUsername = txt_newUsername.Text;
            var oldUsername = txt_username.Text;

            if (!_customerService.CheckDuplicateUsername(newUsername))
            {
                txt_newPassword.Text = String.Empty;
                return;
            }

            if (_customerService.UpdateUsername(newUsername, oldUsername, password, Session.CurrentSession.LoggedInUser.Id))
            {
                lbl_operationsStatus.Text = "Updated Username";
                lbl_operationsStatus.ForeColor = Color.Green;
                ReloadInfo();
            }

            txt_newUsername.Text = String.Empty;
        }
        #endregion

        private void ReloadInfo()
        {
            var data = _customerService.SearchById(Session.CurrentSession.LoggedInUser.Id);
            if (data is not null && data.Count > 0)
            {
                // Save newly changed data to Session User Object
                Session.CurrentSession.LoggedInUser = new Models.Customer()
                {
                    Id = data[0]["id"].ToString(),
                    Username = data[0]["username"].ToString(),
                    Password = data[0]["acc_password"].ToString(),
                    Email = data[0]["email"].ToString(),
                    PhoneNumber = data[0]["ph_number"].ToString()
                };
                // Change the input values with new values
                PopulateInputs();
            }
        }

        private void PopulateInputs()
        {
            username = Session.CurrentSession.LoggedInUser.Username;
            email = Session.CurrentSession.LoggedInUser.Email;
            password = Session.CurrentSession.LoggedInUser.Password;

            txt_email.Text = email;
            txt_username.Text = username;
        }
    }
}
