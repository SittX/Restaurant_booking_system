using System.Data;
using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system
{
    public partial class Frm_login : Form
    {
        private RestaurantDataSetTableAdapters.customersTableAdapter customersTableAdapter = new RestaurantDataSetTableAdapters.customersTableAdapter();
        private RestaurantDataSetTableAdapters.administratorsTableAdapter administratorsTableAdapter = new RestaurantDataSetTableAdapters.administratorsTableAdapter(); 


        public Frm_login()
        {
            InitializeComponent();
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
                var userDt = customersTableAdapter.GetDataByUsernameAndPwd(username, password);
                var adminDt = administratorsTableAdapter.GetDataByUsernameAndPwd(username, password);

                if (userDt.Count() > 0)
                {
                    var name = userDt[0][1].ToString();
                    MessageBox.Show("Authenticated!");
                    Form HomeWindow = new MainWindow();
                    HomeWindow.Show();
                    return true;
                }
                else if (adminDt.Count() > 0)
                {
                    var name = adminDt[0][1].ToString();
                    MessageBox.Show($"Welcome! {name}");
                    Form HomeWindow = new MainWindow();
                    HomeWindow.Show();
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
    }
}