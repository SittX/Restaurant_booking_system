using Motel_booking_system.Admin;
using Motel_booking_system.Helpers;
using Motel_booking_system.Services;

namespace Motel_booking_system
{
    public partial class Frm_login : Form
    {
        private int timerDuration = 60;
        private int loginAttempts = 0;

        public Frm_login()
        {
            InitializeComponent();
        }


        #region Event Handlers
        private void link_registerNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inject customer repository into registeration form
            Form registerationForm = new Frm_userRegisteration(new CustomerService());
            registerationForm.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (this.Owner is not null)
            {
                Application.Exit();
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_username)) return;
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_password)) return;


            var username = txt_username.Text;
            var password = txt_password.Text;

            UserLogin login = new UserLogin(
                new CustomerService(),
                new AdminService()
                );


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
                return;
            }
            // LoginAttempts will be increase everytime the authentication failed
            loginAttempts++;

            if (loginAttempts > 5)
            {
                DisableLoginBtn();
            }
        }

        private void EnableLoginBtn(object? sender, EventArgs e)
        {
            timerDuration--;

            lbl_failureTimer.Text = timerDuration.ToString();

            if (timerDuration <= 0)
            {
                timer.Stop();
                btn_login.Enabled = true;
            }
        }

        private void Frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is not null)
            {
                Application.Exit();
            }
        }
        #endregion

        private void DisableLoginBtn()
        {
            lbl_failureTimer.Visible = true;
            lbl_loginFailureMsg.Visible = true;

            btn_login.Enabled = false; // Disable login button

            timer.Interval = 1000; // Start timer with 1 second interval
            timer.Start();
            timerDuration = 60; // Set timer duration to 60 seconds

            // Subscribe event handler to the timer delegate
            timer.Tick += EnableLoginBtn;

            loginAttempts = 0;
        }

    }

}