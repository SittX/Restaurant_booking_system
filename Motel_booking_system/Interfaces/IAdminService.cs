using Motel_booking_system;
using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Interfaces
{
    public interface IAdminService
    {
        bool Delete(string username, string password);
        BookingDataSet.adminDataTable GetAll();
        bool Insert(Administrator newAdmin);
        BookingDataSet.adminDataTable? Search(string username, string password);
    }
}