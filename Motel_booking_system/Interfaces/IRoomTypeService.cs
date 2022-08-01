namespace Motel_booking_system.Interfaces
{
    public interface IRoomTypeService
    {
        bool Delete(int typeId);
        BookingSystemDataSet.room_typesDataTable GetAll();
        bool Insert(string description, int price);
        int GetRoomTypePrice(int roomNum);
    }
}