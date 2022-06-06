using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_booking_system
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            HideAllSubMenu();
        }

        private void HideAllSubMenu()
        {
            panel_accountSubMenu.Visible = false;
            panel_reservationsMenu.Visible = false;
        }

        private void HideMenus()
        {
            if(panel_accountSubMenu.Visible == true)
            {
                panel_accountSubMenu.Visible = false;
            }
            if(panel_reservationsMenu.Visible == true)
            {
                panel_reservationsMenu.Visible = false;
            }
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

        private void btn_reservationsMenu_Click(object sender, EventArgs e)
        {
            OpenSubMenuPanel(panel_reservationsMenu);
        }

        private void btn_accountMenu_Click(object sender, EventArgs e)
        {
            OpenSubMenuPanel(panel_accountSubMenu);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
