using Motel_booking_system.Interfaces;

namespace Motel_booking_system
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
            // Set Default Color for DGV cells
            dtGridView_history.DefaultCellStyle.ForeColor = Color.Black;
            dtGridView_history.DefaultCellStyle.BackColor = Color.LightSteelBlue;

            // Query all the bookings related to the current user
            var dt = _bookingService.GetBookingsByUserId(Session.CurrentSession.LoggedInUser.Id);
            dtGridView_history.DataSource = dt;
        }
    }
}
