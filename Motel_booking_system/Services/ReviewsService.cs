using Motel_booking_system.BookingDataSetTableAdapters;
using Motel_booking_system.Helpers;
using Restaurant_booking_system.Interfaces;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly reviewsTableAdapter _adapter;

        public ReviewsService()
        {
            _adapter = new reviewsTableAdapter();
        }

        public bool Insert(string cusId, DateTime date, string review)
        {
            try
            {
                if (_adapter.InsertReview(cusId, date, review) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }
        }

        public reviewsDataTable GetAll()
        {
            var data = _adapter.GetData();

            if (data.Count() > 0 && data is not null)
            {
                return data;
            }
            return new reviewsDataTable();

        }

    }
}
