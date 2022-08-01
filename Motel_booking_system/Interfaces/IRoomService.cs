using System.Data;

namespace Motel_booking_system.Interfaces
{
    public interface IRoomService
    {
        bool Delete(int roomNumber);
        BookingSystemDataSet.roomsDataTable GetAll();
        bool Insert(int roomNumber, int roomType, string description, string? img = null);
        DataTable GetAvailableRooms(string checkIn, string checkOut, int roomType);
        bool IsRoomExist(int roomNumber);
    }
}