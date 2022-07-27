using Motel_booking_system;

namespace Restaurant_booking_system.Interfaces
{
    public interface IBookingsService
    {
        BookingDataSet.bookingsDataTable GetBookings();
        bool InsertNewBooking(int roomId, string cusId, string checkIn, string checkOut);
        bool DeleteBooking(int bookingId);
        bool ValidateReservationDate(string checkIn, string checkOut);
    }
}