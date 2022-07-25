using Restaurant_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class RoomsService : IRoomsService
    {
        private readonly roomsTableAdapter _adapter;

        public RoomsService(roomsTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public roomsDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count() <= 0 && data is null)
            {
                return new roomsDataTable();
            }
            return data;
        }

        public bool Insert(int roomNumber, int roomType, string description, string? img = null)
        {

            if (_adapter.InsertNewRoom(roomNumber, roomType, description, img) == 1) return true;
            return false;
        }

        public bool Delete(int roomNumber)
        {
            if (_adapter.DeleteRoom(roomNumber) == 1) return true;
            return false;
        }

        // Will implement it later
        public bool Update(int roomNumber, Room updatedRoom)
        {
            return false;
        }

    }
}
