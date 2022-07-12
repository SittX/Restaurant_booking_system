using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system.Repositories
{
    public class BookingsRepository
    {
        private RestaurantDataSetTableAdapters.bookingsTableAdapter _adapter;
        public BookingsRepository()
        {
            _adapter = new RestaurantDataSetTableAdapters.bookingsTableAdapter();
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
