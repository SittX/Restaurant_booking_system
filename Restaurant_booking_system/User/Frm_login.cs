using Restaurant_booking_system.Admin;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Repositories;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system
{
    public partial class Frm_login : Form
    {

        private adminDataTable _admins = new adminDataTable();
        private customersDataTable _users = new customersDataTable();

        // All the dependencies in Form class are injected into the constructor
        private ICustomerRepository _customerRepo;
        private IAdminRepository _adminRepo;

        public Frm_login(ICustomerRepository customerRepo, IAdminRepository adminRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _adminRepo = adminRepo;
        }

        #region Event handlers
        private void link_registerNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inject customer repository into registeration form
            Form registerationForm = new Frm_userRegisteration(new CustomerRepository(new BookingDataSetTableAdapters.customersTableAdapter()));
            registerationForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser())
            {
                // This should be closed when the user has been authenticated and not hide
                // Try to find a way to close this window !
                SaveSessionOwner();
                this.Hide();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Helper functions

        /// <summary>
        /// This func authenticate if the account exists or not .
        /// If it exists , it will assign the return data table to private variables "_users" or "_admins"
        /// </summary>
        /// <returns> If user exists , return TRUE. Else return FALSE. </returns>
        private bool AuthenticateUser()
        {
            string username = txtBox_loginUsername.Text;
            string password = mskTxtBox_password.Text;
            var users = _customerRepo.Search(username, password);
            var admins = _adminRepo.Search(username, password);
            if(users is not null && admins is not null)
            {
                _users = users;
                _admins = admins;
            }

            if (_users.Count() > 0 || _admins.Count() > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("User not found", "Warning");
                return false;
            }
        }

        /// <summary>
        /// This func save the currently logged in user account into "SessionInfo" class 
        /// </summary>
        /// <returns></returns>
        private void SaveSessionOwner()
        {
            if (_users.Count() > 0)
            {
                Customer currentUser = new Customer()
                {
                    Id = _users[0]["id"].ToString(),
                    Username = _users[0]["username"].ToString(),
                    Password = _users[0]["acc_password"].ToString(),
                    Email = _users[0]["email"].ToString(),
                    PhoneNumber = _users[0]["ph_number"].ToString(),
                    NRC = _users[0]["NRC"].ToString()
                };

                SaveUser(currentUser);

                Form HomeWindow = new Frm_userDashboard();
                HomeWindow.Show();
            }
            else if (_admins.Count() > 0 && _admins is not null)
            {
                Administrator currentAdmin = new Administrator()
                {
                    Id = _admins[0]["id"].ToString(),
                    Username = _admins[0]["username"].ToString(),
                    Password = _admins[0]["password"].ToString()
                };

                SaveUser(currentAdmin);


                Form adminDashboard = new Frm_AdminDashboard();
                adminDashboard.Show();
            }
        }

        /// <summary>
        /// Save currently logged in user to "SessionInfo" class
        /// </summary>
        /// <param name="obj"></param>
        private void SaveUser(object obj)
        {
            // Output current object type into MessageBox
            //MessageBox.Show(obj.GetType().ToString());

            if (obj.GetType() == typeof(Customer))
            {
                Session.Session.LoggedInUser = obj as Customer;
            }
            else
            {
                Session.Session.LoggedInAdmin = obj as Administrator;
            }
        }

        #endregion

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (AuthenticateUser())
            {
                // This should be closed when the user has been authenticated and not hide
                // Try to find a way to close this window !
                SaveSessionOwner();
                this.Hide();
            }
        }
    }

}