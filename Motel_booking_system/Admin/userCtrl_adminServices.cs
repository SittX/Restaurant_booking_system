using Restaurant_booking_system.Admin.PopUpWindows;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Services;

namespace Restaurant_booking_system.Admin
{
    public partial class userCtrl_adminServices : UserControl
    {
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomsService _roomService;

        public userCtrl_adminServices(IRoomTypeService roomTypeService, IRoomsService roomService)
        {
            InitializeComponent();
            _roomTypeService = roomTypeService;
            _roomService = roomService;
        }

        #region Event handlers
        private void userCtrl_adminServices_Load(object sender, EventArgs e)
        {
            PopulateRoom();
            PopulateRoomType();
        }

        private void btn_addNewType_Click(object sender, EventArgs e)
        {
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_newTypeDescription) &&
               !InputValidations.InputValidation.ValidateNullOrEmpty(txtPrice))
            {
                return;
            }


            _roomTypeService.Insert(txt_newTypeDescription.Text, Convert.ToInt32(txtPrice.Text));

            // Empty inputs
            txt_newTypeDescription.Text = String.Empty;
            txtPrice.Text = String.Empty;

            // Reload new items into DtGridView
            PopulateRoomType();
        }


        private void btn_deleteType_Click(object sender, EventArgs e)
        {
            _roomTypeService.Delete(Convert.ToInt32(cmb_typeId.SelectedValue));
            PopulateRoomType();
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            Form form = new Frm_AddNewRoom(
                new RoomsService(),
                new RoomTypeService());
            form.Show();
        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            // Removed ToString(), Might create a bug here
            _roomService.Delete(Convert.ToInt32(cmb_roomNumber.SelectedValue));

            PopulateRoom();
        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            PopulateRoom();
        }
        #endregion



        #region DtGridView populate methods
        private void PopulateRoom()
        {
            dtGridView_rooms.DataSource = _roomService.GetAll();
            var rooms = _roomService.GetAll();

            cmb_roomNumber.DisplayMember = "id";
            cmb_roomNumber.ValueMember = "id";
            cmb_roomNumber.DataSource = rooms;
        }

        private void PopulateRoomType()
        {
            dtGridView_roomTypes.DataSource = _roomTypeService.GetAll();

            var room_Types = _roomTypeService.GetAll();

            cmb_typeId.DisplayMember = "type_description";
            cmb_typeId.ValueMember = "id";
            cmb_typeId.DataSource = room_Types;
        }
        #endregion
    }
}
