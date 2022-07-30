using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using System.Data;

namespace Motel_booking_system
{
    public partial class userCtrl_Reservation : UserControl
    {
        private readonly IBookingsService _bookingService;
        private readonly IRoomsService _roomService;
        private readonly IReviewsService _reviewService;

        private string? checkIn { get; set; }
        private string? checkOut { get; set; }
        private int roomType { get; set; }

        public userCtrl_Reservation(IBookingsService bookingsService, IRoomsService roomService,IReviewsService reviewsService)
        {
            InitializeComponent();
            _bookingService = bookingsService;
            _roomService = roomService;
            _reviewService = reviewsService;
        }
        #region Event handlers

        private void userCtrl_Reservation_Load(object sender, EventArgs e)
        {
            cmb_roomType.ValueMember = "room_type";
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.DataSource = _roomService.GetAll();


            // Set CheckIn datetime picker to current date
            dtPicker_checkIn.MinDate = DateTime.Now;

            // Hide review components
            gpBox_review.Visible = false;


            // Set the default color of the DGV cells
            dtGridView_availableRooms.DefaultCellStyle.ForeColor = Color.Black;
            dtGridView_availableRooms.DefaultCellStyle.BackColor = Color.LightSteelBlue;
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

        private void btn_confirmReservation_Click(object sender, EventArgs e)
        {
            // Booking confirmation
            if (MessageBox.Show($"Booking Details\n Check-in: {checkIn} Check-out: {checkOut}\n Room number: {txt_roomNumber.Text}", "Booking confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            {
                return;
            }


            // Validate inputs using InputValidation
            if (!ValidateInputs())
            {
                OutputMessage.WarningMessage("Input cannot be empty. Please enter all the details for reservation.");
                return;
            }

            if (!_bookingService.ValidateReservationDate(checkIn, checkOut))
            {
                return;
            }

            int roomNumber = Convert.ToInt32(txt_roomNumber.Text);


            _bookingService.InsertNewBooking(roomNumber, Session.CurrentSession.LoggedInUser.Id, checkIn, checkOut);
            gpBox_review.Visible = true;
        }

        private void dtPicker_checkIn_ValueChanged(object sender, EventArgs e)
        {
            dtPicker_checkOut.MinDate = dtPicker_checkIn.Value;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txt_roomNumber.Text))
            {
                return false;
            }
            return true;
        }

        private void btn_submitReview_Click(object sender, EventArgs e)
        {
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_review))
            {
                OutputMessage.WarningMessage("Please enter text to post a review.");
                return;
            }

            string review = txt_review.Text;
            if (_reviewService.Insert(Session.CurrentSession.LoggedInUser.Id, review))
            {

                lbl_reviewStatus.Text = "Thank you for choosing our motel. Hope to see you soon.";
                lbl_reviewStatus.ForeColor = Color.Green;
            }
        }

        private void btn_cancelReview_Click(object sender, EventArgs e)
        {
            gpBox_review.Visible = false;
        } 
        #endregion

    }
}
