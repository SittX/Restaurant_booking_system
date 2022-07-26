using Restaurant_booking_system.Interfaces;
using System.Data;
using System.Data.SqlClient;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class BookingsService : IBookingsService
    {
        private Motel_booking_system.BookingDataSetTableAdapters.bookingsTableAdapter _adapter;
        public BookingsService(Motel_booking_system.BookingDataSetTableAdapters.bookingsTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public bookingsDataTable GetBookings()
        {
            var data = _adapter.GetData();

            if (data.Count() > 0 && data is not null)
            {
                return data;
            }
            return new bookingsDataTable();
        }

        public bool DeleteBooking(int bookingId)
        {
            if (_adapter.DeleteBooking(bookingId) == 1) return true;
            return false;
        }

        public bool InsertNewBooking(int roomId,string cusId,string checkIn,string checkOut)
        {
            //if (_adapter.InsertNewBooking(roomId, cusId, checkIn, checkOut) == 1) return true;
            //return false;

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=motel_booking_db;Integrated Security=True"))
            {

                // Create the command and set its properties.
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO
                                bookings(room_id,cus_id,check_in,check_out)
                                VALUES (@roomId, @cusId, @checkIn, @checkOut);";

                // Add the input parameter and set its properties.
                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@checkIn";
                parameter1.SqlDbType = SqlDbType.Date;
                parameter1.Direction = ParameterDirection.Input;
                parameter1.Value = checkIn;


                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@checkOut";
                parameter2.SqlDbType = SqlDbType.Date;
                parameter2.Direction = ParameterDirection.Input;
                parameter2.Value = checkOut;


                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@roomId";
                parameter3.SqlDbType = SqlDbType.Int;
                parameter3.Direction = ParameterDirection.Input;
                parameter3.Value = roomId;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@cusId";
                parameter4.SqlDbType = SqlDbType.VarChar;
                parameter4.Direction = ParameterDirection.Input;
                parameter4.Value = cusId;


                // Add the parameter to the Parameters collection.
                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);
                command.Parameters.Add(parameter3);
                command.Parameters.Add(parameter4);

                // Open connection to the database
                connection.Open();

                if(command.ExecuteNonQuery() == -1) return false;
                return true;
        }
    }


    }
}
