using Motel_booking_system.Admin.PopUpWindows;
using Motel_booking_system.Interfaces;
using Motel_booking_system.Services;

namespace Motel_booking_system.Admin
{
    public partial class userCtrl_adminServices : UserControl
    {
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;

        public userCtrl_adminServices(IRoomTypeService roomTypeService, IRoomService roomService)
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
            // Check inputs validation and exits the function if the value is invalid
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txt_newTypeDescription)) return;
            if (!InputValidations.InputValidation.ValidateNullOrEmpty(txtPrice)) return;


            _roomTypeService.Insert(txt_newTypeDescription.Text, Convert.ToInt32(txtPrice.Text));

            // Empty inputs
            txt_newTypeDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;

            // Reload new items into DtGridView
            PopulateRoomType();
        }


        private void btn_deleteType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete the selected room type?", "Room type deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            {
                return;
            }

            _roomTypeService.Delete(Convert.ToInt32(cmb_typeId.SelectedValue));
            PopulateRoomType();
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            Form form = new Frm_AdminAddNewRoom( new RoomService(), new RoomTypeService() );
            form.Show();
        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete the selected room?", "Room deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            {
                return;
            }

            _roomService.Delete(Convert.ToInt32(cmb_roomNumber.SelectedValue));
            PopulateRoom();
        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            PopulateRoom();
        }
        #endregion


        #region Methods
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
