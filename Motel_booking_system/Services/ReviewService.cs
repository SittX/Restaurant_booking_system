using Motel_booking_system.BookingSystemDataSetTableAdapters;
using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using static Motel_booking_system.BookingSystemDataSet;

namespace Motel_booking_system.Services
{
    public class ReviewService : IReviewService
    {
        private readonly reviewsTableAdapter _adapter;

        public ReviewService()
        {
            _adapter = new reviewsTableAdapter();
        }

        #region Service methods
        public bool Insert(string cusId, string review)
        {
            try
            {
                if (_adapter.InsertReview(cusId, review) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage("A new review cannot be created. Please try again.");
                return false;
            }
        }

        public reviewsDataTable GetAll()
        {
            var data = _adapter.GetData();

            if (data.Count > 0 && data is not null)
            {
                return data;
            }
            return new reviewsDataTable();
        }
        #endregion

    }
}
