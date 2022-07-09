using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Interfaces
{
    public interface ICustomerRepository
    {
        bool Delete(string username, string password);
        RestaurantDataSet.customersDataTable GetAll();
        bool Insert(User new_customer);
        RestaurantDataSet.customersDataTable? Search(string username, string password);
        RestaurantDataSet.customersDataTable SearchById(int id);
        bool UpdatePassword(string new_password, string old_password, string username);
        bool UpdateUsername(string new_username, string old_username, string password);
    }
}