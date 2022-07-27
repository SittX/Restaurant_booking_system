using System.ComponentModel;

namespace Motel_booking_system.User
{
    public partial class userCtrl_reviewItem : UserControl
    {
        public userCtrl_reviewItem()
        {
            InitializeComponent();
        }

        private string _username;
        private string _review;


        [Category("Custrom props")]
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                lbl_username.Text = value;
            }
        }

        [Category("Custrom props")]
        public string Review
        {
            get => _review;
            set
            {
                _review = value;
                lbl_review.Text = value;
            }
        }
    }
}
