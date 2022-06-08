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
            Form registerationForm = new Frm_registeration();
            registerationForm.Show();
        }

        // Authentication and authorization code should goes here
        private void btn_login_Click(object sender, EventArgs e)
        {

            Form HomeWindow = new MainWindow();
            HomeWindow.Show();


            //this.Close();

        }
    }
}