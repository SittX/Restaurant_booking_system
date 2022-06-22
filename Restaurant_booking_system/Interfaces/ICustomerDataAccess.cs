using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Interfaces
{
    internal interface ICustomerDataAccess
    {
        void Delete(string username, string password);
        RestaurantDataSet.customersDataTable GetAll();
        RestaurantDataSet.customersDataTable Search(string username, string password);
        bool Insert(User new_customer);
        void UpdatePassword(string new_password, string old_password, string username);
        void UpdateUsername(string new_username, string old_username, string id);
    }
}