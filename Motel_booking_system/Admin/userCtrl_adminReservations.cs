using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Services;

namespace Restaurant_booking_system.Admin
{
    public partial class userCtrl_adminReservations : UserControl
    {
        private IBookingsService _bookingService;
        public userCtrl_adminReservations(IBookingsService bookingsService)
        {
            InitializeComponent();
            _bookingService = bookingsService;
        }

        private void btn_makeReservation_Click(object sender, EventArgs e)
        {
            Form reservationFrm = new Frm_AdminAddReservation(
                new RoomsService(new Motel_booking_system.BookingDataSetTableAdapters.roomsTableAdapter()),
                new BookingsService(new Motel_booking_system.BookingDataSetTableAdapters.bookingsTableAdapter()),
                new CustomerService(new Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter())
                );

            reservationFrm.Show();
        }

        private void userCtrl_adminReservations_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            int bookingId = Convert.ToInt32(cmb_bookingId.SelectedValue);
            _bookingService.DeleteBooking(bookingId);
            PopulateData();
        }

        private void PopulateData()
        {
            var dt = _bookingService.GetBookings();
            dtGridView_bookings.DataSource = dt;


            // Populate Booking Id combobox
            cmb_bookingId.DisplayMember = "id";
            cmb_bookingId.ValueMember = "id";
            cmb_bookingId.DataSource = dt;
        }
    }
}
