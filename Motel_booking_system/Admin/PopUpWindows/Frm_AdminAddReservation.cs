
using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using Motel_booking_system.Models;
using System.Data;


namespace Motel_booking_system.Admin
{
    public partial class Frm_AdminAddReservation : Form
    {
        private readonly IRoomService _roomService;
        private readonly IBookingService _bookingService;
        private readonly ICustomerService _customerService;
        private readonly IRoomTypeService _roomTypeService;

        private string? checkIn { get; set; }
        private string? checkOut { get; set; }
        private int roomType { get; set; }

        private string? userId { get; set; }

        public Frm_AdminAddReservation(IRoomService roomService, IBookingService bookingService, ICustomerService customerService,IRoomTypeService roomTypeService)
        {
            InitializeComponent();
            _roomService = roomService;
            _bookingService = bookingService;
            _customerService = customerService;
            _roomTypeService = roomTypeService;
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
            // Populate combox values
            cmb_roomType.ValueMember = "room_type";
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.DataSource = _roomService.GetAll();

            // Set CheckIn datetime picker minimum value to current date
            dtPicker_checkIn.MinDate = DateTime.Now;

            // Set the default color of the DGV cells
            dtGridView_availableRooms.DefaultCellStyle.ForeColor = Color.Black;
            dtGridView_availableRooms.DefaultCellStyle.BackColor = Color.LightSteelBlue;
        }

        private void btn_confirmReservation_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                OutputMessage.WarningMessage("Inputs cannot be empty. Please enter all the required details for reservation.");
                return;
            }

            if (!_bookingService.ValidateReservationDate(checkIn, checkOut))
            {
                return;
            }

            int roomNumber = Convert.ToInt32(txt_bookingRoomNumber.Text);
            
            var totalPrice = CalculateTotalPrice(roomNumber);

            // Booking confirmation
            if (MessageBox.Show($"Booking Details\n Check-in: {checkIn} Check-out: {checkOut}\n Total price: {totalPrice}", "Booking confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            {
                return;
            }

            NewUserAccountCreation();


            // Make bookings with newly created user account
            _bookingService.InsertNewBooking(roomNumber, userId, checkIn, checkOut,totalPrice);

        }

        private void dtPicker_checkIn_ValueChanged(object sender, EventArgs e)
        {
            dtPicker_checkOut.MinDate = dtPicker_checkIn.Value;
        }
        #endregion


        #region Methods
        private bool CreateAccount(string username, string email, string phoneNumber)
        {
            try
            {
                var users = _customerService.GetAll();
                userId = Customer.GenerateId(users);
                var encryptedPassword = PasswordEncryption.Encrypt(username);
                Customer newUser = new Customer() { Id = userId, Username = username, Email = email, PhoneNumber = phoneNumber, Password = encryptedPassword };
                return _customerService.Insert(newUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message : {ex.Message}");
                OutputMessage.ErrorMessage("Cannot create account. Please try again.");
                return false;
            }
        }

        private void NewUserAccountCreation()
        {

            if (!ValidateInputs())
            {
                OutputMessage.ErrorMessage("Inputs cannot be empty. Please enter all the required details for reservation.");
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

            if (!CreateAccount(username, email, phoneNumber))
            {
                OutputMessage.ErrorMessage("User account cannot be created. Please try again");
                return;
            }
        }

        private bool ValidateInputs()
        {   
            if (!InputValidations.InputValidation.ValidateEmail(txt_cusEmail)) return false;
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_cusName)) return false;
            if (!InputValidations.InputValidation.ValidatePhoneNumber(txt_cusPhNumber)) return false;
            if (string.IsNullOrEmpty(txt_bookingRoomNumber.Text)) return false;
            if (string.IsNullOrEmpty(checkIn)) return false;
            if (string.IsNullOrEmpty(checkOut)) return false;

            return true;
        }

        private int CalculateTotalPrice(int roomNumber)
        {
            var totalBookedDays = dtPicker_checkOut.Value.Subtract(dtPicker_checkIn.Value);
            var dates = totalBookedDays.TotalDays;

            var price = _roomTypeService.GetRoomTypePrice(roomNumber);

            var totalPrice = price * dates;
            return Convert.ToInt32(totalPrice);
        }
        #endregion



    }
}
