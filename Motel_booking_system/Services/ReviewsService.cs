using Motel_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly reviewsTableAdapter _adapter;

        public ReviewsService(reviewsTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public bool Insert(string cusId, DateTime date, string review)
        {
            if (_adapter.InsertReview(cusId, date, review) == 1) return true;
            return false;
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
