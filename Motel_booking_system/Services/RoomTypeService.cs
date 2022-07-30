using Motel_booking_system.BookingDataSetTableAdapters;
using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using static Motel_booking_system.BookingDataSet;

namespace Motel_booking_system.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly room_typesTableAdapter _adapter;

        public RoomTypeService()
        {
            _adapter = new room_typesTableAdapter();
        }

        #region service methods
        public room_typesDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count <= 0 && data is null)
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
                Console.WriteLine($"Error message : {ex.Message}");
                OutputMessage.ErrorMessage("New room type cannot be inserted. Please try again");
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
                Console.WriteLine($"Error message : {ex.Message}");
                OutputMessage.ErrorMessage("Room type cannot be deleted. Please try again.");
                return false;
            }

        } 
        #endregion

    }
}
