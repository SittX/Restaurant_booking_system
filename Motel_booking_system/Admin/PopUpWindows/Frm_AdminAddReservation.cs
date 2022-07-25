
using Restaurant_booking_system.Interfaces;
using System.Data.SqlTypes;

namespace Restaurant_booking_system.Admin
{
    public partial class Frm_AdminAddReservation : Form
    {
        private readonly IRoomsService _roomService;
        private readonly IBookingsService _bookingService;

        private BookingDataSetTableAdapters.bookingsTableAdapter _demoBooking = new BookingDataSetTableAdapters.bookingsTableAdapter();
        public Frm_AdminAddReservation(IRoomsService roomService,IBookingsService bookingService)
        {
            InitializeComponent();
            _roomService = roomService;
            _bookingService = bookingService;
        }

        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtPicker_checkIn.Value.ToString("yyyy,MM,dd"));
        }

        private void btn_searchRooms_Click(object sender, EventArgs e)
        {
            // Fucking bug is right here but don't know how to solve it ......
            
            string checkIn = dtPicker_checkIn.Value.ToString("yyyyMMdd");
            string checkOut = dtPicker_checkOut.Value.ToString("yyyyMMdd");

            //var dt = _demoBooking.(checkIn,checkOut);

            //dtGridView_availableRooms.DataSource = dt;
        }

        private void Frm_AdminAddReservation_Load(object sender, EventArgs e)
        {
            cmb_roomType.ValueMember = "id";
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.DataSource = _roomService.GetAll();
        }
    }
}
