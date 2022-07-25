using Restaurant_booking_system.Interfaces;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class BookingsService : IBookingsService
    {
        private BookingDataSetTableAdapters.bookingsTableAdapter _adapter;
        public BookingsService(BookingDataSetTableAdapters.bookingsTableAdapter adapter)
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

    }
}
