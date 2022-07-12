using Restaurant_booking_system.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system
{
    public partial class userCtrl_Reservation : UserControl
    {
        BookingsRepository repo = new BookingsRepository();
        bookingsDataTable bookings;
        string? col1, col2, col3;
        DateTime col4;
        
        public userCtrl_Reservation()
        {
            InitializeComponent();
        }

        private void userCtrl_Reservation_Load(object sender, EventArgs e)
        {
            bookings = repo.GetBookings();
            dtGrid_availableRooms.DataSource = bookings;
            SeperateTime();
            checkDataTime();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SeperateTime()
        {
           col1 = bookings[0]["check_in"].ToString();
           col2 = bookings[0]["check_out"].ToString();
           col3 = bookings[0]["customer_id"].ToString();
           col4 = (DateTime)bookings[0]["booked_date"];

            MessageBox.Show($"{col1} : {col2} : {col3} : {col4}");
        }
         private void checkDataTime()
        {
            var date = col4.Date.ToString();
            DateTime dateObj = DateTime.Now;
            MessageBox.Show($"Booked Data is : {date} \n Datetime object : {dateObj.Day}");
        }


    }
}
