
using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using Motel_booking_system.Models;
using System.Data;


namespace Motel_booking_system.Admin
{
    public partial class Frm_AdminAddReservation : Form
    {
        private readonly IRoomsService _roomService;
        private readonly IBookingsService _bookingService;
        private readonly ICustomerService _customerService;

        private string? checkIn { get; set; }
        private string? checkOut { get; set; }
        private int roomType { get; set; }

        private string? userId { get; set; }

        public Frm_AdminAddReservation(IRoomsService roomService, IBookingsService bookingService, ICustomerService customerService)
        {
            InitializeComponent();
            _roomService = roomService;
            _bookingService = bookingService;
            _customerService = customerService;
        }

        #region Event handlers
        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_searchRooms_Click(object sender, EventArgs e)
        {
            checkIn = dtPicker_checkIn.Value.ToString("yyyy-MM-dd");
            checkOut = dtPicker_checkOut.Value.ToString("yyyy-MM-dd");
            roomType = Convert.ToInt32(cmb_roomType.SelectedValue);

            if (!_bookingService.ValidateReservationDate(checkIn, checkOut))
            {
                return;
            }

            DataTable availableRoomDataTable = _roomService.GetAvailableRooms(checkIn, checkOut, roomType);

            dtGridView_availableRooms.DataSource = availableRoomDataTable;
        }

        private void Frm_AdminAddReservation_Load(object sender, EventArgs e)
        {
            cmb_roomType.ValueMember = "room_type";
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.DataSource = _roomService.GetAll();

            // Set CheckIn datetime picker minimum value to current date
            dtPicker_checkIn.MinDate = DateTime.Now;
        }

        private void btn_confirmReservation_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                OutputMessage.WarningMessage("Input cannot be empty. Please enter all the details for reservation.");
                return;
            }

            if (!_bookingService.ValidateReservationDate(checkIn, checkOut))
            {
                return;
            }

            int roomNumber = Convert.ToInt32(txt_bookingRoomNumber.Text);

            CreateNewUserAccount();


            // Make bookings with newly created user account
            _bookingService.InsertNewBooking(roomNumber, userId, checkIn, checkOut);

        }

        private void dtPicker_checkIn_ValueChanged(object sender, EventArgs e)
        {
            dtPicker_checkOut.MinDate = dtPicker_checkIn.Value;
        }
        #endregion


        #region Methods
        private bool CreateNewUserAccount(string username, string email, string phoneNumber)
        {
            try
            {
                var users = _customerService.GetAll();
                userId = Customer.GenerateId(users);
                Customer newUser = new Customer() { Id = userId, Username = username, Email = email, PhoneNumber = phoneNumber, Password = username };
                return _customerService.Insert(newUser);
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage("Cannot create account. Please try again.");
                return false;
            }

        }

        private void CreateNewUserAccount()
        {

            //Validate inputs
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_cusName)
                && !InputValidations.InputValidation.ValidateEmail(txt_cusEmail)
                && !InputValidations.InputValidation.ValidatePhoneNumber(txt_cusPhNumber)
                )
            {
                return;
            }

            string username = txt_cusName.Text;
            string email = txt_cusEmail.Text;
            string phoneNumber = txt_cusPhNumber.Text;

            // Check if the username already exists or not
            if (!_customerService.CheckDuplicateUsername(username))
            {
                return;
            }


            if (!CreateNewUserAccount(username, email, phoneNumber))
            {
                OutputMessage.ErrorMessage("User account cannot be created.Please try again");
                return;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txt_bookingRoomNumber.Text)
                && string.IsNullOrEmpty(checkIn)
                && string.IsNullOrEmpty(checkOut))
            {
                return false;
            }
            return true;
        } 
        #endregion
    }
}
