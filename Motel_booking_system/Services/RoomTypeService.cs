using Motel_booking_system.BookingDataSetTableAdapters;
using Motel_booking_system.Helpers;
using Restaurant_booking_system.Interfaces;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private room_typesTableAdapter _adapter;

        public RoomTypeService()
        {
            _adapter = new room_typesTableAdapter();
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



        public bool Insert(string description, int price)
        {
            try
            {
                if (_adapter.InsertNewRoomType(description, price) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }
        }


        public bool Delete(int typeId)
        {
            try
            {
                if (_adapter.DeleteRoomType(typeId) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

        }

        public bool Update(string oldDescription, string newDescription, int newPrice)
        {
            try
            {
                if (_adapter.UpdateRoomType(newDescription, newPrice, oldDescription) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

        }
    }
}
