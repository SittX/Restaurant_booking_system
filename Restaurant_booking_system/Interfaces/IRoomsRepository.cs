using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Interfaces
{
    public interface IRoomsRepository
    {
        bool Delete(int roomNumber);
        BookingDataSet.roomsDataTable GetAll();
        bool Insert(int roomNumber, int roomType, string description,int price);
        bool Update(int roomNumber, Room updatedRoom);
    }
}