using Restaurant_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_booking_system.Repositories
{
    public class ReviewsRepository : IReviewsRepository
    {
        private readonly reviewsTableAdapter _adapter;

        public ReviewsRepository(reviewsTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public bool Insert(string cusId, DateTime date, string review)
        {
            if (_adapter.InsertReview(cusId, date, review) == 1) return true;
            return false;
        }

    }
}
