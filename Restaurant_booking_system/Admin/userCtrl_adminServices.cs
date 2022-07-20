using Restaurant_booking_system.Admin.PopUpWindows;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Repositories;

namespace Restaurant_booking_system.Admin
{
    public partial class userCtrl_adminServices : UserControl
    {
        //private BookingDataSetTableAdapters.room_typesTableAdapter _TypesTableAdapter = new BookingDataSetTableAdapters.room_typesTableAdapter();
        //private BookingDataSetTableAdapters.roomsTableAdapter roomsTableAdapter = new BookingDataSetTableAdapters.roomsTableAdapter();
        private readonly IRoomTypeRepository _roomTypeRepo;
        private readonly IRoomsRepository _roomRepo;

        public userCtrl_adminServices(IRoomTypeRepository roomTypeRepo, IRoomsRepository roomRepo)
        {
            InitializeComponent();
            _roomTypeRepo = roomTypeRepo;
            _roomRepo = roomRepo;
        }

        private void userCtrl_adminServices_Load(object sender, EventArgs e)
        {
            PopulateRoom();
            PopulateRoomType();
        }

        private void btn_addNewType_Click(object sender, EventArgs e)
        {
            _roomTypeRepo.Insert(txt_newTypeDescription.Text,Convert.ToInt32(txtPrice.Text));
            PopulateRoomType();
        }

        // Need to add error handling for empty values
        private void btn_deleteType_Click(object sender, EventArgs e)
        {
            _roomTypeRepo.Delete(Convert.ToInt32(cmb_typeId.SelectedValue));
            PopulateRoomType();

        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            Form form = new Frm_AddNewRoom(
                new RoomsRepository(new BookingDataSetTableAdapters.roomsTableAdapter()),
                new RoomTypeRepository(new BookingDataSetTableAdapters.room_typesTableAdapter()));
            form.Show();
        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            _roomRepo.Delete(Convert.ToInt32(cmb_roomNumber.SelectedValue.ToString()));

            PopulateRoom();
        }

        private void PopulateRoom()
        {
            dtGridView_rooms.DataSource = _roomRepo.GetAll();
            var rooms = _roomRepo.GetAll();

            cmb_roomNumber.DisplayMember = "id";
            cmb_roomNumber.ValueMember = "id";
            cmb_roomNumber.DataSource = rooms;
        }

        private void PopulateRoomType()
        {
            dtGridView_roomTypes.DataSource = _roomTypeRepo.GetAll();

            var room_Types = _roomTypeRepo.GetAll();

            cmb_typeId.DisplayMember = "type_description";
            cmb_typeId.ValueMember = "id";
            cmb_typeId.DataSource = room_Types;
        }
    }
}
