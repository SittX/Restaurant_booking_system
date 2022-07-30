using static Motel_booking_system.BookingDataSet;

namespace Motel_booking_system.Interfaces
{
    public interface IBookingsService
    {
        bookingsDataTable GetBookings();
        bool InsertNewBooking(int roomId, string cusId, string checkIn, string checkOut);
        bool DeleteBooking(int bookingId);
        bool ValidateReservationDate(string checkIn, string checkOut);
        bookingsDataTable GetBookingsByUserId(string customerId);
    }
}