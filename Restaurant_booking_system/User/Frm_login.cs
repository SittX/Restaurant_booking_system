using Restaurant_booking_system.Admin;
using Restaurant_booking_system.Helpers;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Repositories;
using static Restaurant_booking_system.BookingDataSet;

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
                new CustomerRepository(
                    new BookingDataSetTableAdapters.customersTableAdapter()
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
                new CustomerRepository(new BookingDataSetTableAdapters.customersTableAdapter()),
                new AdminRepository(new BookingDataSetTableAdapters.adminTableAdapter()));

            // Authenticate the current user and open the form that they have access to open
            if (login.LoginUser(username, password))
            {

                if (Session.Session.IsAdmin)
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
    }

}