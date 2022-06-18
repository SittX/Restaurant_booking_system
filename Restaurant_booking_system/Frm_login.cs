using System.Data;

namespace Restaurant_booking_system
{
    public partial class Frm_login : Form
    {
        private RestaurantDataSet.customersTableAdapter customerTableAdapter = new RestaurantDataSet.customersTableAdapter();
        private RestaurantDataSet.administratorsTableAdapter adminTableAdapter = new RestaurantDataSet.administratorsTableAdapter();
        public Frm_login()
        {
            InitializeComponent();
        }

        private void link_registerNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerationForm = new RegisterationForm();
            registerationForm.Show();
        }

        // Authentication and authorization code should goes here
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtBox_loginUsername.Text;

           var data = customerTableAdapter.GetData();
            DataTable dt = new DataTable();
            dt = data;
            var customers = data.Select();
            foreach(var customer in customers)
            {
               if( customer.Field<string>(username) == "Kevin")
                {
                    MessageBox.Show("This is called during the authentication of the user");
                }
            }
            


            MessageBox.Show(data.ToString());


            //Form HomeWindow = new MainWindow();
            //HomeWindow.Show();


            //this.Close();

        }
    }
}