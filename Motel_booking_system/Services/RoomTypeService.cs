using Motel_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly room_typesTableAdapter _adapter;

        public RoomTypeService(room_typesTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public room_typesDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count() <= 0 && data is null)
            {
                return new room_typesDataTable();
            }
            return data;
        }

        public bool Insert(string description,int price)
        {
            if (_adapter.InsertNewRoomType(description,price) == 1) return true;
            return false;
        }


        public bool Delete(int typeId)
        {
            if (_adapter.DeleteRoomType(typeId) == 1) return true;
            return false;
        }

        public bool Update(string oldDescription, string newDescription,int newPrice)
        {
            if (_adapter.UpdateRoomType(newDescription,newPrice, oldDescription) == 1) return true;
            return false;
        }
    }
}
