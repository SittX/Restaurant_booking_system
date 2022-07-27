using Restaurant_booking_system.Admin;
using Restaurant_booking_system.Helpers;
using Restaurant_booking_system.Services;

namespace Restaurant_booking_system
{
    public partial class Frm_login : Form
    {

        public Frm_login()
        {
            InitializeComponent();
        }


        private void link_registerNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inject customer repository into registeration form
            Form registerationForm = new Frm_userRegisteration(
                new CustomerService(
                    )
                );
            registerationForm.Show();
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            var username = txtBox_loginUsername.Text;
            var password = mskTxtBox_password.Text;


            UserLogin login = new UserLogin(
                new CustomerService(),
                new AdminService());

            // Authenticate the current user and open the form that they have access to open
            if (login.LoginUser(username, password))
            {

                if (Session.CurrentSession.IsAdmin)
                {
                    Form adminDashboard = new Frm_AdminDashboard();
                    adminDashboard.Show();
                }
                else
                {
                    Form userDashboard = new Frm_userDashboard();
                    userDashboard.Show();
                }
                this.Hide();

            }

        }

        private void Frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is not null)
            {
                Application.Exit();
            }
        }
    }

}