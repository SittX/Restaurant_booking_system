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

        #region ToolStrip menu items

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form loginForm = new Frm_login();
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

        private void btn_account_Click(object sender,EventArgs e)
        {
            SwitchUserControl(new userCtrl_Account());
        }

        private void btn_reservations_Click(object sender,EventArgs e)
        {
            SwitchUserControl(new userCtrl_Reservation());
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_history());
        }

        #endregion


    }
}
