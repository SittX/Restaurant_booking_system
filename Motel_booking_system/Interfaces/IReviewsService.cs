namespace Restaurant_booking_system.Interfaces
{
    public interface IReviewsService
    {
        bool Insert(string cusId, DateTime date, string review);
    }
}