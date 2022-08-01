using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;

namespace Motel_booking_system.Admin.PopUpWindows
{
    public partial class Frm_AdminAddNewRoom : Form
    {
        private readonly IRoomService _roomService;
        private readonly IRoomTypeService _roomTypeService;
        private string? imgFilePath;
        public Frm_AdminAddNewRoom(IRoomService roomService, IRoomTypeService roomTypeService)
        {
            InitializeComponent();
            _roomService = roomService;
            _roomTypeService = roomTypeService;

        }

        #region Event handlers
        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            // Check empty or invalid input values
            if (string.IsNullOrEmpty(txt_roomNo.Text))
            {
                OutputMessage.WarningMessage("Input values can be empty or null. Please check your inputs.");
                return;
            }

            if (string.IsNullOrEmpty(txt_description.Text))
            {
                OutputMessage.WarningMessage("Input values can be empty or null. Please check your inputs.");
                return;
            }

            var roomNumber = Convert.ToInt32(txt_roomNo.Text);
            var roomType = Convert.ToInt32(cmb_roomType.SelectedValue);
            var description = txt_description.Text;

            // Check if the room number already exists or not
            if (!_roomService.IsRoomExist(roomNumber))
            {
                return;
            }

            // If imgFilePath is empty, insert new room without picture
            if (string.IsNullOrEmpty(imgFilePath))
            {
                _roomService.Insert(roomNumber, roomType, description);
                this.Close();
                return;
            }

            // If imgFilePath is not empty , insert imgFilePath into new room
            _roomService.Insert(roomNumber, roomType, description, imgFilePath);
            this.Close();
        }

        private void Frm_AddNewRoom_Load(object sender, EventArgs e)
        {
            var roomTypes = _roomTypeService.GetAll();

            // Populate room type combo box
            cmb_roomType.DisplayMember = "type_description";
            cmb_roomType.ValueMember = "id";
            cmb_roomType.DataSource = roomTypes;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_roomNo.Text = string.Empty;
            txt_description.Text = string.Empty;
            this.Close();
        }

        private void btn_browseImg_Click(object sender, EventArgs e)
        {
            // Create new OpenFileDialog object
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Choose image of the room.";
            ofd.Multiselect = false;

            // Check if the selected file has the allowed file extensions
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgFilePath = ofd.FileName;

                var fileExtension = Path.GetExtension(imgFilePath);

                switch (fileExtension)
                {
                    case ".png":
                        picBox_roomImg.ImageLocation = imgFilePath;
                        break;
                    case ".jpg":
                        picBox_roomImg.ImageLocation = imgFilePath;
                        break;
                    case ".jpeg":
                        picBox_roomImg.ImageLocation = imgFilePath;
                        break;
                    default:
                        MessageBox.Show("File type is not accepted.");
                        break;
                }

            }
        }
        #endregion


    }
}
