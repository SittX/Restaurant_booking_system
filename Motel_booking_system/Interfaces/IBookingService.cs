using static Motel_booking_system.BookingSystemDataSet;

namespace Motel_booking_system.Interfaces
{
    public interface IBookingService
    {
        bookingsDataTable GetBookings();
        bool InsertNewBooking(int roomId, string cusId, string checkIn, string checkOut,int totalPrice);
        bool DeleteBooking(int bookingId);
        bool ValidateReservationDate(string checkIn, string checkOut);
        bookingsDataTable GetBookingsByUserId(string customerId);
    }
}