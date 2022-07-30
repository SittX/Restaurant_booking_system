using static Motel_booking_system.BookingDataSet;

namespace Motel_booking_system.Interfaces
{
    public interface IReviewsService
    {
        bool Insert(string cusId, string review);
        reviewsDataTable GetAll();
    }
}