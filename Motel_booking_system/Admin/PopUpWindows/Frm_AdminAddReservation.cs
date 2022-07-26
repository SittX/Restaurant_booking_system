
using Motel_booking_system.Helpers;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_booking_system.Admin
{
    public partial class Frm_AdminAddReservation : Form
    {
        private readonly IRoomsService _roomService;
        private readonly IBookingsService _bookingService;
        private readonly ICustomerService _customerService;

        private string checkIn { get; set; }
        private string checkOut { get; set; }
        private int roomType { get; set; }

        private string userId { get; set; }

        private Motel_booking_system.BookingDataSetTableAdapters.roomsTableAdapter _demoBooking = new Motel_booking_system.BookingDataSetTableAdapters.roomsTableAdapter();
        public Frm_AdminAddReservation(IRoomsService roomService, IBookingsService bookingService, ICustomerService customerService)
        {
            InitializeComponent();
            _roomService = roomService;
            _bookingService = bookingService;
            _customerService = customerService;
        }

        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_searchRooms_Click(object sender, EventArgs e)
        {
            checkIn = dtPicker_checkIn.Value.ToString("yyyy-MM-dd");
            checkOut = dtPicker_checkOut.Value.ToString("yyyy-MM-dd");
            roomType = Convert.ToInt32(cmb_roomType.SelectedValue);

           DataTable dt =  _roomService.GetAvailableRooms(checkIn, checkOut, roomType);

            dtGridView_availableRooms.DataSource = dt;
        }

        private void Frm_AdminAddReservation_Load(object sender, EventArgs e)
        {
            cmb_roomType.ValueMember = "room_type";
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.DataSource = _roomService.GetAll();
        }

        private void btn_confirmReservation_Click(object sender, EventArgs e)
        {
            // Insert booking into database
            string username = txt_cusName.Text;
            string NRC = txt_nrc.Text;
            string email = txt_cusEmail.Text;
            string phoneNumber = txt_cusPhNumber.Text;

            // Will require validation logic here
            if (!CreateNewUserAccount(username, NRC, email, phoneNumber))
            {
                OutputMessage.ErrorMessage("User account cannot be created.Please try again");
            }

            // Make bookings with newly created user account
            _bookingService.InsertNewBooking(200,userId,checkIn,checkOut);

        }

        private bool CreateNewUserAccount(string username, string NRC, string email, string phoneNumber)
        {
            var users = _customerService.GetAll();
            userId = Customer.GenerateId(users);
           Customer newUser = new Customer() { Id = userId,Username = username, NRC = NRC, Email = email, PhoneNumber = phoneNumber,Password = NRC};
            return _customerService.Insert(newUser);
        }
    }
}
