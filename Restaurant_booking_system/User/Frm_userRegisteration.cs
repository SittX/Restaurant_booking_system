using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using static Restaurant_booking_system.InputValidations.InputValidation;

namespace Restaurant_booking_system
{
    public partial class Frm_userRegisteration : Form
    {

        /// <summary>
        /// This class is used for creating new user account
        /// User password should also be hashed for data security
        /// We should also check the phone number of the user
        /// </summary>
        private ICustomerRepository _repo;
        public Frm_userRegisteration(ICustomerRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void btn_saveRegisteration_Click(object sender, EventArgs e)
        {

            if (!ValidateInputs())
            {
                lbl_registerationStatus.Text = "Invalid inputs";
                lbl_registerationStatus.ForeColor = Color.Red;
            }


            Customer newUser = new Customer()
            {
                Email = txt_email.Text,
                Username = txt_username.Text,
                Password = txt_password.Text,
                PhoneNumber = txt_phNumber.Text,
                NRC = txt_nrc.Text
            };

            if (_repo.Insert(newUser))
            {
                lbl_registerationStatus.Text = "User account has been succefully created !";
                lbl_registerationStatus.ForeColor = Color.Green;
            }

        }

        private bool ValidateInputs()
        {
            // Validate input is not null or empty
            if (!ValidateNullOrEmpty(txt_email)
               && !ValidateNullOrEmpty(txt_password)
               && !ValidateNullOrEmpty(txt_phNumber)
               && !ValidateNullOrEmpty(txt_nrc)
               && !ValidateNullOrEmpty(txt_username)
               && !ValidateEmail(txt_email))
            {
                return false;
            }
            return true;
        }

    }


}
