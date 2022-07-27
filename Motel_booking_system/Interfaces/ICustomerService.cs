using Motel_booking_system;
using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Interfaces
{
    public interface ICustomerService
    {
        bool Delete(string username, string password);
        BookingDataSet.customersDataTable GetAll();
        bool Insert(Customer newCus);
        BookingDataSet.customersDataTable? Search(string username, string password);
        BookingDataSet.customersDataTable? SearchById(string id);
        bool UpdatePassword(string newPassword, string oldPassword, string username);
        bool UpdateUsername(string newUsername, string oldUsername, string password);
        bool CheckDuplicateUsername(string username);
    }
}