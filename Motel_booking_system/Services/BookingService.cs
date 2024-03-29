﻿using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using System.Data;
using System.Data.SqlClient;
using static Motel_booking_system.BookingSystemDataSet;

namespace Motel_booking_system.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingSystemDataSetTableAdapters.bookingsTableAdapter _adapter;
        public BookingService()
        {
            _adapter = new BookingSystemDataSetTableAdapters.bookingsTableAdapter();
        }

        #region Service methods
        public bookingsDataTable GetBookings()
        {
            var data = _adapter.GetData();

            if (data.Count > 0 && data is not null)
            {
                return data;
            }
            return new bookingsDataTable();
        }

        public bool DeleteBooking(int bookingId)
        {
            try
            {
                if (_adapter.DeleteBooking(bookingId) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage("Service cannot be deleted. Please try again.");
                return false;
            }
        }

        public bookingsDataTable GetBookingsByUserId(string customerId)
        {
            try
            {
                var data = _adapter.GetDataByCustomerId(customerId);

                if (data.Count > 0 && data is not null)
                {
                    return data;
                }
                return new bookingsDataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage($"Bookings for customer Id : {customerId} cannot be found. Please check your inputs.");
                return new bookingsDataTable();
            }
        }

        public bool ValidateReservationDate(string checkIn, string checkOut)
        {
            var checkInDate = Convert.ToInt32(checkIn.Split('-')[2]);
            var checkOutDate = Convert.ToInt32(checkOut.Split('-')[2]);
            var checkInMonth = Convert.ToInt32(checkIn.Split('-')[1]);
            var checkOutMonth = Convert.ToInt32(checkOut.Split('-')[1]);

            if (checkOutDate < checkInDate && checkOutMonth <= checkInMonth)
            {
                OutputMessage.ErrorMessage("Check-ut date cannot be less than check-in date.");
                return false;
            }
            return true;
        }

        public bool InsertNewBooking(int roomId, string cusId, string checkIn, string checkOut,int totalPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=motel_bookings_system_db;Integrated Security=True"))
                {

                    // Create the command and set its properties.
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO
                                bookings(room_id,cus_id,check_in,check_out,total_price)
                                VALUES (@roomId, @cusId, @checkIn, @checkOut,@total_price);";

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

                    SqlParameter parameter5 = new SqlParameter();
                    parameter5.ParameterName = "@total_price";
                    parameter5.SqlDbType = SqlDbType.VarChar;
                    parameter5.Direction = ParameterDirection.Input;
                    parameter5.Value = totalPrice;


                    // Add the parameters to the command.
                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);
                    command.Parameters.Add(parameter3);
                    command.Parameters.Add(parameter4);
                    command.Parameters.Add(parameter5);

                    // Open connection to the database
                    connection.Open();

                    if (command.ExecuteNonQuery() == -1) return false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage("Booking cannot be inserted. Please try again.");
                return false;
            }

        }
        #endregion


    }
}
