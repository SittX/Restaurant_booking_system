using Motel_booking_system.BookingDataSetTableAdapters;
using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using System.Data;
using System.Data.SqlClient;
using static Motel_booking_system.BookingDataSet;

namespace Motel_booking_system.Services
{
    public class RoomsService : IRoomsService
    {
        private readonly roomsTableAdapter _adapter;

        public RoomsService()
        {
            _adapter = new roomsTableAdapter();
        }

        #region Service methods
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
            try
            {
                if (_adapter.InsertNewRoom(roomNumber, roomType, description, img) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.WarningMessage("New room cannot be added. Please try again.");
                return false;
            }

        }

        public bool Delete(int roomNumber)
        {
            try
            {
                if (_adapter.DeleteRoom(roomNumber) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.WarningMessage("Room cannot be deleted. Please try again.");
                return false;
            }

        }


        public bool IsRoomExist(int roomNumber)
        {
            try
            {
                var dt = _adapter.GetDataByRoomNumber(roomNumber);
                var count = dt.Count;
                if (dt.Count > 0 && dt is not null)
                {
                    OutputMessage.WarningMessage("Room number already exists. Please try again.");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage("Cannot find the room. Please try again.");
                throw;
            }
        }

        public DataTable GetAvailableRooms(string checkIn, string checkOut, int roomType)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Price", typeof(string));

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

                try
                {
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

                                //dt.Rows.Add(reader[0], reader[1], reader[2]);
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error message: {ex.Message}");
                    OutputMessage.ErrorMessage("Cannot search available room. Please try again.");
                }

                connection.Close();
            }

            return dt;
        } 
        #endregion
    }
}
