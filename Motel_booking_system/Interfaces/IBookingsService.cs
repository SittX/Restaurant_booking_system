using Restaurant_booking_system;

namespace Restaurant_booking_system.Interfaces
{
    public interface IBookingsService
    {
        BookingDataSet.bookingsDataTable GetBookings();
    }
}