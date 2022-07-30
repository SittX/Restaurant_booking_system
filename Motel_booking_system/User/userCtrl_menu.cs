using Motel_booking_system.Interfaces;

namespace Motel_booking_system.User
{
    public partial class userCtrl_menu : UserControl
    {
        private IRoomsService _repo;


        public userCtrl_menu(IRoomsService repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void userCtrl_menu_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            var rooms = _repo.GetAll();


            // MenuItems array
            userCtrl_menuItem[] menuItems = new userCtrl_menuItem[rooms.Count];

            // this list is used to filter all the rooms so only one room for one room_type shows up
            var roomType = new List<string>();

            // Filter duplicate room types
            for (int i = 1; i < menuItems.Length; i++)
            {
                // If the room_type does not exist in the MenuItems roomType List , it will add to the list.
                if (!roomType.Contains(rooms[i]["type_description"].ToString()))
                {
                    roomType.Add(rooms[i]["type_description"].ToString());

                    menuItems[i] = new userCtrl_menuItem();
                    menuItems[i].Type = rooms[i]["type_description"].ToString();
                    menuItems[i].Price = rooms[i]["price"].ToString();
                    menuItems[i].Img = rooms[i]["img"].ToString();
                }

                // Add to flowLayoutPanel
                AddToFlowLayoutPanel(menuItems[i]);
            }
        }


        private void AddToFlowLayoutPanel(userCtrl_menuItem menuItem)
        {
            if (flowLayoutPanel.Controls.Count < 0)
            {
                flowLayoutPanel.Controls.Clear();
            }
            else
            {
                flowLayoutPanel.Controls.Add(menuItem);
            }
        }
    }
}
