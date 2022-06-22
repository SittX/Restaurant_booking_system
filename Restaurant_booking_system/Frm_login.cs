using Restaurant_booking_system.Admin;
using Restaurant_booking_system.DataAccess;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Session;
using System.Data;
using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system
{
    public partial class Frm_login : Form
    {
        private ICustomerDataAccess _customerDataAccess;
        private IAdminDataccess _adminDataAccess;
        public Frm_login()
        {
            InitializeComponent();
            _customerDataAccess = new CustomerDataAccess();
            _adminDataAccess = new AdminDataccess();
        }

        private void link_registerNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerationForm = new RegisterationForm();
            registerationForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser())
            {
                // This should be closed when the user has been authenticated and not hide
                // Try to find a way to close this window !
                this.Hide();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool AuthenticateUser()
        {
            try
            {
                string username = txtBox_loginUsername.Text;
                string password = mskTxtBox_password.Text;
                var userDt = _customerDataAccess.Search(username, password);
                var adminDt = _adminDataAccess.Search(username, password);

                if (userDt != null)
                {
                    User currentUser = new User()
                    {
                        Firstname = userDt[0][1].ToString(),
                        Lastname = userDt[0][2].ToString(),
                        Username = userDt[0][3].ToString(),
                        Password = userDt[0][4].ToString(),
                        Email = userDt[0][5].ToString()
                    };
                    LogUser(currentUser);

                    Form HomeWindow = new MainWindow();
                    HomeWindow.Show();

                    return true;
                }
                else if (adminDt != null)
                {
                    Administrator currentAdmin = new Administrator()
                    {
                        Id = Convert.ToInt32(adminDt[0][0]),
                        Username = adminDt[0][1].ToString(),
                        Password = adminDt[0][2].ToString()
                    };
                    LogUser(currentAdmin);


                    Form adminDashboard = new Frm_AdminDashboard();
                    adminDashboard.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("No user found");
                    return false;
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message,"No user found");
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
                return false;
            }
        }

        private void LogUser(object obj)
        {
            MessageBox.Show(obj.GetType().ToString());
            if(obj.GetType() == typeof(User))
            {
                SessionInfo.LoggedInUser = obj as User;
            }
            else
            {
                SessionInfo.LoggedInAdmin = obj as Administrator;
            }
        }
    }
}