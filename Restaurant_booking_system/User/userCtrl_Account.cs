using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Repositories;

namespace Restaurant_booking_system
{
    public partial class userCtrl_Account : UserControl
    {
        private string? username, email, password;

        private ICustomerRepository _repo;
        public userCtrl_Account(ICustomerRepository repo)
        {
            InitializeComponent();
            _repo = repo;
            //_repo = new CustomerRepository(new BookingDataSetTableAdapters.customersTableAdapter());
        }

        private void userCtrl_Account_Load(object sender, EventArgs e)
        {
            username = Session.Session.LoggedInUser.Username;
            email = Session.Session.LoggedInUser.Email;
            password = Session.Session.LoggedInUser.Password;

            txt_email.Text = email;
            txt_username.Text = username;
        }

        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            // Check if the password textbox is null or not
            if (!string.IsNullOrEmpty(txt_newPassword.Text))
            {
                var oldPassword = txt_oldPassword.Text;
                var newPassword = txt_newPassword.Text;

                // Check if the operations is success or not
                if (_repo.UpdatePassword(newPassword,oldPassword,username))
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
            if (_repo.UpdateUsername(newUsername,oldUsername,password))
            {
                lbl_operationsStatus.Text = "Updated Username";
                lbl_operationsStatus.ForeColor = Color.Green;
                ReloadInfo();
            }
        }

        private void ReloadInfo()
        {
            var data = _repo.SearchById(Session.Session.LoggedInUser.Id);
            if (data.Count() > 0)
            {
                // Save newly changed data to Session User Object
                Session.Session.LoggedInUser = new Models.Customer()
                {
                    Id = data[0]["id"].ToString(),
                    Username = data[0]["username"].ToString(),
                    Password = data[0]["acc_password"].ToString(),
                    Email = data[0]["email"].ToString(),
                    NRC = data[0]["NRC"].ToString(),
                    PhoneNumber= data[0]["ph_number"].ToString()
                };
                // Reload the form to update the value
                userCtrl_Account_Load(this, EventArgs.Empty);
            }
        }
    }
}
