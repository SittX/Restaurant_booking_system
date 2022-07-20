using Restaurant_booking_system.Interfaces;

namespace Restaurant_booking_system.Admin.PopUpWindows
{
    public partial class Frm_AddNewRoom : Form
    {
        private readonly IRoomsRepository _roomRepo;
        private readonly IRoomTypeRepository _roomTypeRepo;
        private string filePath;
        public Frm_AddNewRoom(IRoomsRepository roomRepo, IRoomTypeRepository roomTypeRepo)
        {
            InitializeComponent();
            _roomRepo = roomRepo;
            _roomTypeRepo = roomTypeRepo;

        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            var roomNumber = Convert.ToInt32(txt_roomNo.Text);
            var roomType = Convert.ToInt32(cmb_roomType.SelectedValue);
            var description = txt_description.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                _roomRepo.Insert(roomNumber, roomType, description);
                this.Close();
                return;
            }
            _roomRepo.Insert(roomNumber, roomType, description, filePath);
            this.Close();

            // Update DtGridView_room of "userCtrl_adminService" panel
        }

        private void Frm_AddNewRoom_Load(object sender, EventArgs e)
        {
            var roomTypes = _roomTypeRepo.GetAll();
            
            // Populate room type combo box
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.ValueMember = "id";
            cmb_roomType.DataSource = roomTypes;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_roomNo.Text = String.Empty;
            txt_description.Text = String.Empty;
        }

        private void btn_browseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Choose image of the room.";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;

                var fileExtension = Path.GetExtension(filePath);

                switch (fileExtension)
                {
                    case ".png":
                        picBox_roomImg.ImageLocation = filePath;
                        break;
                    case ".jpg":
                        picBox_roomImg.ImageLocation = filePath;
                        break;
                    case ".jpeg":
                        picBox_roomImg.ImageLocation = filePath;
                        break;
                    default:
                        MessageBox.Show("File type is not accepted.");
                        break;
                }

            }
        }


    }
}
