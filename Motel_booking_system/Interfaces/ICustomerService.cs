using Motel_booking_system.Models;

namespace Motel_booking_system.Interfaces
{
    public interface ICustomerService
    {
        bool Delete(string username, string password);
        BookingDataSet.customersDataTable GetAll();
        bool Insert(Customer newCus);
        BookingDataSet.customersDataTable? Search(string username, string password);
        BookingDataSet.customersDataTable? SearchById(string id);
        bool UpdatePassword(string newPassword, string oldPassword, string userId);
        bool UpdateUsername(string newUsername, string oldUsername, string password, string userId);
        bool CheckDuplicateUsername(string username);
    }
}