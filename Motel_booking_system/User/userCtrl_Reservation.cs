using Motel_booking_system;
using Restaurant_booking_system.Interfaces;
using System.Data;

namespace Restaurant_booking_system
{
    public partial class userCtrl_Reservation : UserControl
    {
        private readonly IBookingsService _bookingService;

        private readonly IRoomsService _roomService;

        private string checkIn { get; set; }
        private string checkOut { get; set; }
        private int roomType { get; set; }

        public userCtrl_Reservation(IBookingsService bookingsService,IRoomsService roomService)
        {
            InitializeComponent();
            _bookingService = bookingsService;
            _roomService = roomService;
        }

        private void userCtrl_Reservation_Load(object sender, EventArgs e)
        {
            cmb_roomType.ValueMember = "room_type";
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.DataSource = _roomService.GetAll();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_searchRooms_Click(object sender, EventArgs e)
        {
            checkIn = dtPicker_checkIn.Value.ToString("yyyy-MM-dd");
            checkOut = dtPicker_checkOut.Value.ToString("yyyy-MM-dd");
            roomType = Convert.ToInt32(cmb_roomType.SelectedValue);

            DataTable dt = _roomService.GetAvailableRooms(checkIn, checkOut, roomType);

            dtGridView_availableRooms.DataSource = dt;
        }

        private void btn_confirmReservation_Click(object sender, EventArgs e)
        {
           int roomNumber = Convert.ToInt32(txt_roomNumber.Text);


            _bookingService.InsertNewBooking(roomNumber, Session.CurrentSession.LoggedInUser.Id, checkIn, checkOut);
        }



        //private void SeperateTime()
        //{
        //    col1 = bookings[0]["check_in"].ToString();
        //    col2 = bookings[0]["check_out"].ToString();
        //    col3 = bookings[0]["customer_id"].ToString();
        //    col4 = (DateTime)bookings[0]["booked_date"];

        //    MessageBox.Show($"{col1} : {col2} : {col3} : {col4}");
        //}
        //private void checkDataTime()
        //{
        //    var date = col4.Date.ToString();
        //    DateTime dateObj = DateTime.Now;
        //    MessageBox.Show($"Booked Data is : {date} \n Datetime object : {dateObj.Day}");
        //}


    }
}
