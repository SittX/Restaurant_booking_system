using Motel_booking_system.Models;
using Motel_booking_system.Services;

namespace Motel_booking_system.Admin
{
    public partial class Frm_AdminDashboard : Form
    {
        public Frm_AdminDashboard()
        {
            InitializeComponent();
            SwitchUserControl(new userCtrl_adminMenu());
        }
        private void Frm_AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutUser()
        {
            Session.CurrentSession.IsAdmin = false;
            Session.CurrentSession.LoggedInAdmin = new Administrator();

            Form login = new Frm_login();
            login.Owner = this;
            login.Show();


            this.Hide();
        }


        #region Menubar navigation event handlers
        private void SwitchUserControl(UserControl userCtrl)
        {
            userCtrl.Dock = DockStyle.Fill;
            userCtrl.Show();
            panel_mainBackground.Controls.Clear();
            panel_mainBackground.Controls.Add(userCtrl);
        }
        private void btn_account_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_AdminAccount(
                new AdminService()
                    )
                );
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminReservations(new BookingService()));
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            //SwitchUserControl(new userCtrl_adminServices(new ServicesRepository(new BookingDataSetTableAdapters.roomsTableAdapter()));
            SwitchUserControl(
                new userCtrl_adminServices(
                new RoomTypeService(),
                new RoomService()
                   )
                );
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminMenu());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogOutUser();
        }

        #endregion

        #region Menu strips buttons

        private void menuStrip_reservations_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminReservations(new BookingService()));
        }

        private void menuStrip_account_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_AdminAccount(
                new AdminService()
                    )
                );
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

        private void menuStrip_services_Click(object sender, EventArgs e)
        {
            SwitchUserControl(
                new userCtrl_adminServices(
                new RoomTypeService(),
                new RoomService()
                   )
                );
        }


        private void menuStrip_menu_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminMenu());
        }
        #endregion

    }
}
