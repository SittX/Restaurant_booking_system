using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_booking_system;
namespace Restaurant_booking_system
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenSubMenuPanel(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                SubMenu.Visible = true;
            }else if(SubMenu.Visible == true)
            {
                SubMenu.Visible = false;
            }
        }

        #region Exit buttons
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SubMenu button
        private void btn_account_Click(object sender, EventArgs e)
        {
            OpenSubMenuPanel(panel_accountSubMenu);
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            OpenSubMenuPanel(panel_reservationsMenu);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region  Main panel user controls

        // Add User Control to the Main panel
        private void AddUserControl(UserControl userCtrl)
        {
            panel_main.Controls.Clear();
            userCtrl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(userCtrl);
            userCtrl.Show();
        }
        private void btn_coupleReservation_Click(object sender, EventArgs e)
        { 
            AddUserControl(new userCtrl_coupleReservation());
        }


        private void btn_familyReservation_Click(object sender, EventArgs e)
        {
            AddUserControl(new userCtrl_familyReservation());
        }

        private void btn_eventsReservation_Click(object sender, EventArgs e)
        {
            AddUserControl(new userCtrl_eventsReservation());
        }
        private void btn_history_Click(object sender, EventArgs e)
        {
            AddUserControl(new userCtrl_history());
        }

        #endregion 

    }
}
