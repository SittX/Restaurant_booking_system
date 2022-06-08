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
    public partial class Frm_registeration : Form
    {
        public Frm_registeration()
        {
            InitializeComponent();
        }


        private void btn_cancelUserCreation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
