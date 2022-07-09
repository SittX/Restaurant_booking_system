using Restaurant_booking_system.Admin;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Session;
using System.Data;
using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system
{
    public partial class Frm_login : Form
    {
        
        private administratorsDataTable _admins = new administratorsDataTable();
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
            Form registerationForm = new Frm_userRegisteration();
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
        /// <returns></returns>
        private bool AuthenticateUser()
        {
            string username = txtBox_loginUsername.Text;
            string password = mskTxtBox_password.Text;
            _users = _customerRepo.Search(username, password);
            _admins = _adminRepo.Search(username, password);
            
            if(_users.Count() > 0 || _admins.Count() > 0)
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
                if (_users.Count() > 0 && _users is not null)
                {
                    User currentUser = new User()
                    {
                        Id = Convert.ToInt32(_users[0][0].ToString()),
                        Firstname = _users[0][1].ToString(),
                        Lastname = _users[0][2].ToString(),
                        Username = _users[0][3].ToString(),
                        Password = _users[0][4].ToString(),
                        Email = _users[0][5].ToString()
                    };

                    LogUser(currentUser);

                    Form HomeWindow = new Frm_userDashboard();
                    HomeWindow.Show();
                }
                else if (_admins.Count() > 0 && _admins is not null)
                {
                    Administrator currentAdmin = new Administrator()
                    {
                        Id = Convert.ToInt32(_admins[0][0]),
                        Username = _admins[0][1].ToString(),
                        Password = _admins[0][2].ToString()
                    };

                    LogUser(currentAdmin);


                    Form adminDashboard = new Frm_AdminDashboard();
                    adminDashboard.Show();
                }
            }

        /// <summary>
        /// Save currently logged in user to "SessionInfo" class
        /// </summary>
        /// <param name="obj"></param>
        private void LogUser(object obj)
        {
            MessageBox.Show(obj.GetType().ToString());
            if(obj.GetType() == typeof(User))
            {
                Session.Session.LoggedInUser = obj as User;
            }
            else
            {
                Session.Session.LoggedInAdmin = obj as Administrator;
            }
        }

        #endregion
    }

}