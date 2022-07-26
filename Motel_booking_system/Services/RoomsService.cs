using Motel_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System.Data;
using System.Data.SqlClient;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class RoomsService : IRoomsService
    {
        private readonly roomsTableAdapter _adapter;

        public RoomsService(roomsTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public roomsDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count() <= 0 && data is null)
            {
                return new roomsDataTable();
            }
            return data;
        }

        public bool Insert(int roomNumber, int roomType, string description, string? img = null)
        {

            if (_adapter.InsertNewRoom(roomNumber, roomType, description, img) == 1) return true;
            return false;
        }

        public bool Delete(int roomNumber)
        {
            if (_adapter.DeleteRoom(roomNumber) == 1) return true;
            return false;
        }

        // Will implement it later
        public bool Update(int roomNumber, Room updatedRoom)
        {
            return false;
        }


        public DataTable GetAvailableRooms(string checkIn, string checkOut,int roomType)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber");
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=motel_booking_db;Integrated Security=True"))
            {

                // Create the command and set its properties.
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT rooms.id,rooms.room_description,room_types.price
        FROM room_types
        INNER JOIN rooms
        ON rooms.room_type = (
	        SELECT DISTINCT room_type
	        FROM rooms AS  r
	        WHERE NOT EXISTS 
		        (
			        SELECT 1
			        FROM bookings AS b
			        WHERE b.check_in <= @checkOut 
			        AND b.check_out >= @checkin
			        AND b.room_id = r.id
		        )
			        AND room_type = @roomType
        ) AND room_types.id = (
	        SELECT DISTINCT room_type
	        FROM rooms AS  r
	        WHERE NOT EXISTS 
		        (
			        SELECT 1
			        FROM bookings AS b
			        WHERE b.check_in <= @checkOut 
			        AND b.check_out >= @checkin
			        AND b.room_id = r.id
		        )
			        AND room_type = @roomType
        )";

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
                parameter3.ParameterName = "@roomType";
                parameter3.SqlDbType = SqlDbType.Int;
                parameter3.Direction = ParameterDirection.Input;
                parameter3.Value = roomType;


                // Add the parameter to the Parameters collection.
                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);
                command.Parameters.Add(parameter3);

                // Open connection to the database
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataRow dr = dt.NewRow(); // have new row on each iteration
                            dr["RoomNumber"] = reader[0];
                            dr["Description"] = reader[1];
                            dr["Price"] = reader[2];
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                connection.Close();
            }

            return dt;
        }
    }
}
