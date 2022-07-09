using static Restaurant_booking_system.InputValidations.InputValidation;
using Restaurant_booking_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.DataAccess;

namespace Restaurant_booking_system
{
    public partial class Frm_userRegisteration : Form
    {

        /// <summary>
        /// This class is used for creating new user account
        /// User password should also be hashed for data security
        /// We should also check the phone number of the user
        /// </summary>
        private ICustomerRepository _customerDataAccess;
        public Frm_userRegisteration()
        {
            InitializeComponent();
            _customerDataAccess= new CustomerRepository();

        }

        private void btn_saveRegisteration_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    User newUser = new User()
                    {
                        Email = txtbox_email.Text,
                        Username = txtbox_username.Text,
                        Password = txtbox_password.Text,
                        PhoneNumber = txtbox_phNumber.Text
                    };

                    if(_customerDataAccess.Insert(newUser))
                    {
                        lbl_registerationStatus.Text = "User account has been succefully created !";
                        lbl_registerationStatus.ForeColor = Color.Green;
                    }
                }
                else
                {
                    lbl_registerationStatus.Text = "Please check inputs";
                    lbl_registerationStatus.ForeColor = Color.Red;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool ValidateInputs()
        {
            // Validate input is not null or empty
            if(ValidateNullOrEmpty(txtbox_email)
               && ValidateNullOrEmpty(txtbox_password)
               && ValidateNullOrEmpty(txtbox_phNumber)
               && ValidateNullOrEmpty(txtbox_username))
            {
                // Validate email address 
                if (ValidateEmail(txtbox_email))
                {
                    return true;
                }

                return false;
            } 

            return false;
        }
        
    }
}
