namespace Restaurant_booking_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void link_registerNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerationForm = new RegisterationForm();
            registerationForm.Show();
        }
    }
}