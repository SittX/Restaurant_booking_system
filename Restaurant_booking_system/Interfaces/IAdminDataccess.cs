using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Interfaces
{
    internal interface IAdminDataccess
    {
        void Delete(int id,string password);
        RestaurantDataSet.administratorsDataTable GetAll();
        bool Insert(Administrator new_admin);
        RestaurantDataSet.administratorsDataTable Search(string username, string password);
        void Update(int id, Administrator updatedAccount, Administrator originalAccount);
    }
}