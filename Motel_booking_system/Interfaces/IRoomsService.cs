using Motel_booking_system;
using Restaurant_booking_system.Models;
using System.Data;

namespace Restaurant_booking_system.Interfaces
{
    public interface IRoomsService
    {
        bool Delete(int roomNumber);
        BookingDataSet.roomsDataTable GetAll();
        bool Insert(int roomNumber, int roomType, string description,string? img = null);
        bool Update(int roomNumber, Room updatedRoom);
        DataTable GetAvailableRooms(string checkIn, string checkOut, int roomType);
    }
}