using System.ComponentModel;

namespace Restaurant_booking_system.User
{
    public partial class userCtrl_menuItem : UserControl
    {
        public userCtrl_menuItem()
        {
            InitializeComponent();
        }

        private string _type;
        private string _price;
        private string _img;


        [Category("Custrom props")]
        public string Type
        {
            get => _type; 
            set
            {
                _type = value;
                lbl_type.Text = value;
            }
        }

        [Category("Custrom props")]
        public string Price
        {
            get => _price; 
            set
            {
                _price = value;
                lbl_price.Text = value;
            }
        }

        [Category("Custrom props")]
        public string Img
        {
            get => _img;
            set { _img = value; picBox_img.ImageLocation = value; }
        }
    }
}
