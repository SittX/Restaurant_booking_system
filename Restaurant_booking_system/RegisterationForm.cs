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
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
        }

        private void btn_closeLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelUserCreation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
