using Motel_booking_system.Models;

namespace Motel_booking_system.Interfaces
{
    public interface IAdminService
    {
        bool Delete(string username, string password);
        BookingSystemDataSet.administratorsDataTable GetAll();
        bool Insert(Administrator newAdmin);
        BookingSystemDataSet.administratorsDataTable? Search(string username, string password);
        bool CheckDuplicateUsername(string username);
    }
}