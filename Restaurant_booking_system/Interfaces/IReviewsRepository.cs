namespace Restaurant_booking_system.Interfaces
{
    public interface IReviewsRepository
    {
        bool Insert(string cusId, DateTime date, string review);
    }
}