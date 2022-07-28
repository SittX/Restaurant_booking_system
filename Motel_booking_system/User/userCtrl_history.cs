using Restaurant_booking_system.Interfaces;

namespace Restaurant_booking_system
{
    public partial class userCtrl_history : UserControl
    {
        private readonly IBookingsService _bookingService;

        public userCtrl_history(IBookingsService bookingService)
        {
            InitializeComponent();
            _bookingService = bookingService;
        }

        private void userCtrl_history_Load(object sender, EventArgs e)
        {
            // Query all the bookings related to the current user
            dtGridView_history.DataSource = _bookingService.GetBookingsByUserId(Session.CurrentSession.LoggedInUser.Id);
        }
    }
}
