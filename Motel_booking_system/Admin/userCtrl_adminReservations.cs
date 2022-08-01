using Motel_booking_system.Interfaces;
using Motel_booking_system.Services;

namespace Motel_booking_system.Admin
{
    public partial class userCtrl_adminReservations : UserControl
    {
        private IBookingService _bookingService;
        public userCtrl_adminReservations(IBookingService bookingsService)
        {
            InitializeComponent();
            _bookingService = bookingsService;
        }

        private void btn_makeReservation_Click(object sender, EventArgs e)
        {
            Form reservationFrm = new Frm_AdminAddReservation(
                new RoomService(),
                new BookingService(),
                new CustomerService(),
                new RoomTypeService()
                );

            reservationFrm.Show();
        }

        private void userCtrl_adminReservations_Load(object sender, EventArgs e)
        {
            PopulateData();

            // Set the default color of the DGV cells
            dtGridView_bookings.DefaultCellStyle.ForeColor = Color.Black;
            dtGridView_bookings.DefaultCellStyle.BackColor = Color.LightSteelBlue;
        }

        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            int bookingId = Convert.ToInt32(cmb_bookingId.SelectedValue);

            if (MessageBox.Show($"Are you sure to delete booking id {bookingId.ToString()} ?", "Booking deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            {
                return;
            }

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
