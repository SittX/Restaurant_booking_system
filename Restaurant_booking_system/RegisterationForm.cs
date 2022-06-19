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

namespace Restaurant_booking_system
{
    public partial class RegisterationForm : Form
    {

        /// <summary>
        /// This class is used for creating new user account
        /// User password should also be hashed for data security
        /// We should also check the phone number of the user
        /// </summary>
        private RestaurantDataSetTableAdapters.customersTableAdapter customerTableAdapter;
        public RegisterationForm()
        {
            InitializeComponent();
            customerTableAdapter = new RestaurantDataSetTableAdapters.customersTableAdapter();

        }

        private void btn_saveRegisteration_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    User _newUser = new User()
                    {
                        Firstname = txtbox_fname.Text,
                        Lastname = txtbox_lname.Text,
                        Email = txtbox_email.Text,
                        Username = txtbox_username.Text,
                        Password = txtbox_password.Text,
                        PhoneNumber = txtbox_phNumber.Text
                    };

                    customerTableAdapter.Insert(_newUser.Firstname, _newUser.Lastname, _newUser.Username, _newUser.Password, _newUser.Email);
                    lbl_registerationStatus.Text = "User account has been succefully created !";
                    lbl_registerationStatus.ForeColor = Color.Green;
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
               && ValidateNullOrEmpty(txtbox_fname)
               && ValidateNullOrEmpty(txtbox_password)
               && ValidateNullOrEmpty(txtbox_lname)
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
