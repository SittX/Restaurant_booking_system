using Restaurant_booking_system.Services;

namespace Restaurant_booking_system.Admin
{
    public partial class userCtrl_adminReservations : UserControl
    {
        public userCtrl_adminReservations()
        {
            InitializeComponent();
        }

        private void btn_makeReservation_Click(object sender, EventArgs e)
        {
            Form reservationFrm = new Frm_AdminAddReservation(
                new RoomsService(new BookingDataSetTableAdapters.roomsTableAdapter()),
                new BookingsService(new BookingDataSetTableAdapters.bookingsTableAdapter())
                );

            reservationFrm.Show();
        }
    }
}
