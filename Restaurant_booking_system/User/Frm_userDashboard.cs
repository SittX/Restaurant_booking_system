using Restaurant_booking_system.Repositories;

namespace Restaurant_booking_system
{
    public partial class Frm_userDashboard : Form
    {
        public Frm_userDashboard()
        {
            InitializeComponent();
        }

        #region ToolStrip menu items

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form loginForm = new Frm_login(new CustomerRepository(new BookingDataSetTableAdapters.customersTableAdapter()), new AdminRepository(new BookingDataSetTableAdapters.adminTableAdapter()));
                loginForm.Show();

                this.Close();
            }
        }
        #endregion

        #region  Main panel user controls

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
            SwitchUserControl(new userCtrl_Account(new CustomerRepository(new BookingDataSetTableAdapters.customersTableAdapter())));
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_Reservation());
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_history());
        }


        #endregion

        private void bookingsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
