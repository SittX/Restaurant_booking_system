using static Motel_booking_system.BookingSystemDataSet;

namespace Motel_booking_system.Interfaces
{
    public interface IReviewService
    {
        bool Insert(string cusId, string review);
        reviewsDataTable GetAll();
    }
}