using Motel_booking_system.Models;
using Motel_booking_system.Services;
using Motel_booking_system.User;

namespace Motel_booking_system
{
    public partial class Frm_userDashboard : Form
    {
        public Frm_userDashboard()
        {
            InitializeComponent();

            SwitchUserControl(new userCtrl_menu(new RoomService()));
        }

        private void Frm_userDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutUser()
        {
            Session.CurrentSession.IsUser = false;
            Session.CurrentSession.LoggedInUser = new Customer();
            Form login = new Frm_login();
            login.Owner = this;
            login.Show();

            this.Hide();
        }


        #region  Event handlers

        // Add User Control to the Main panel
        private void SwitchUserControl(UserControl userCtrl)
        {
            panel_main.Controls.Clear();
            userCtrl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(userCtrl);
            userCtrl.Show();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_Account(new CustomerService()));
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_Reservation(new BookingService(), new RoomService(), new ReviewService(),new RoomTypeService()));
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_history(new BookingService()));
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogOutUser();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_menu(new RoomService()));
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_reviewsList(new ReviewService()));
        }
        #endregion


        #region MenuStrip items
        private void menuStrip_menu_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_menu(new RoomService()));
        }

        private void menuStrip_booking_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_Reservation(new BookingService(), new RoomService(), new ReviewService(), new RoomTypeService()));
        }

        private void menuStrip_account_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_Account(new CustomerService()));
        }

        private void menuStrip_history_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_history(new BookingService()));
        }

        private void menuStrip_logout_Click(object sender, EventArgs e)
        {
            LogOutUser();
        }

        private void menuStrip_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            return;
        }

        private void menuStrip_reviews_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_reviewsList(new ReviewService()));
        }
        #endregion
    }
}
