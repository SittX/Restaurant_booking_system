using Motel_booking_system;

namespace Restaurant_booking_system.Interfaces
{
    public interface IRoomTypeService
    {
        bool Delete(int typeId);
        BookingDataSet.room_typesDataTable GetAll();
        bool Insert(string description, int price);
        bool Update(string oldDescription, string newDescription, int newPrice);
    }
}