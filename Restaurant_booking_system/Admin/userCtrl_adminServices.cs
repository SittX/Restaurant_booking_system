using Restaurant_booking_system.Interfaces;

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
            dtGridView_rooms.DataSource = _roomRepo.GetAll();

            dtGridView_roomTypes.DataSource = _roomTypeRepo.GetAll();


            var room_Types =  _roomTypeRepo.GetAll();

            cmb_typeId.DisplayMember = "type_description";
            cmb_typeId.ValueMember = "id";
            cmb_typeId.DataSource= room_Types;

            var rooms = _roomRepo.GetAll();

            cmb_roomNumber.DisplayMember = "id";
            cmb_roomNumber.ValueMember = "id";
            cmb_roomNumber.DataSource = rooms;

        }

        private void btn_addNewType_Click(object sender, EventArgs e)
        {
            _roomTypeRepo.Insert(txt_newTypeDescription.Text);
        }

        private void btn_deleteService_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_roomNumber.SelectedValue.ToString());
        }

        private void btn_deleteType_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_typeId.SelectedValue.ToString());

        }
    }
}
