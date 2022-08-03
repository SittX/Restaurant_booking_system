using Motel_booking_system.Interfaces;
using Motel_booking_system.Models;
using static Motel_booking_system.InputValidations.InputValidation;

namespace Motel_booking_system
{
    public partial class Frm_userRegisteration : Form
    {
        private ICustomerService _customerService;
        public Frm_userRegisteration(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        #region Event handlers
        private void btn_saveRegisteration_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                lbl_registerationStatus.Text = "Invalid inputs";
                lbl_registerationStatus.ForeColor = Color.Red;
                return;
            }

            // Check duplicate username
            if (!_customerService.CheckDuplicateUsername(txt_username.Text))
            {
                txt_username.Text = String.Empty;
                return;
            }


            Customer newUser = new Customer()
            {
                Email = txt_email.Text,
                Username = txt_username.Text,
                Password = txt_password.Text,
                PhoneNumber = txt_phNumber.Text
            };

            if (_customerService.Insert(newUser))
            {
                lbl_registerationStatus.Text = "User account has been succefully created !";
                lbl_registerationStatus.ForeColor = Color.Green;
                this.Close();
            }

        }


        private void btn_cancelRegisteration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private bool ValidateInputs()
        {
            // Validate input is not null or empty
            if (!ValidateNullOrEmpty(txt_username)) return false;
            if (!ValidateNullOrEmpty(txt_password)) return false;
            if (!ValidateEmail(txt_email)) return false;
            if (!ValidatePhoneNumber(txt_phNumber)) return false;
            return true;
        }

    }


}
