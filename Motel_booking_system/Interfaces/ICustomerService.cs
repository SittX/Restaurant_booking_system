using Motel_booking_system.Models;

namespace Motel_booking_system.Interfaces
{
    public interface ICustomerService
    {
        bool Delete(string username, string password);
        BookingSystemDataSet.customersDataTable GetAll();
        bool Insert(Customer newCus);
        BookingSystemDataSet.customersDataTable? Search(string username, string password);
        BookingSystemDataSet.customersDataTable? SearchById(string id);
        bool UpdatePassword(string newPassword, string oldPassword, string userId);
        bool UpdateUsername(string newUsername, string oldUsername, string password, string userId);
        bool CheckDuplicateUsername(string username);
    }
}