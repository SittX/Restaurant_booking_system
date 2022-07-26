using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>
    internal class CustomerService : ICustomerService
    {
        private Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter _adapter;
        public CustomerService(Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public bool Delete(string username, string password)
        {
            if (_adapter.DeleteAccount(username, password) == 1)
            {
                return true;
            }

            return false;
        }

        public customersDataTable GetAll()
        {
            var data = _adapter.GetData();

            if (data.Count() <= 0 && data is null)
            {
                return new customersDataTable();
            }
            return data;
        }

        public bool Insert(Customer newCus)
        {
            if (_adapter.InsertNewCustomerAcc(
                                              Customer.GenerateId(_adapter.GetData()),
                                              newCus.Username,
                                              newCus.Password,
                                              newCus.Email,
                                              newCus.NRC,
                                              newCus.PhoneNumber) == 1) return true;
            return false;
        }

        public customersDataTable? Search(string username, string password)
        {
            var data = _adapter.GetDataByUsernameAndPassword(username, password);

            if (data.Count() <= 0 && data is null)
            {
                return new customersDataTable();
            }
            return data;
        }

        public customersDataTable? SearchById(string id)
        {
            var data = _adapter.GetDataById(id);

            if (data.Count() <= 0 && data is null)
            {
                return new customersDataTable();
            }
            return data;
        }

        public bool UpdatePassword(string newPassword, string oldPassword, string username)
        {
            if (_adapter.UpdatePassword(newPassword, username, oldPassword) == 1) return true;
            return false;
        }

        public bool UpdateUsername(string newUsername, string oldUsername, string password)
        {
            if (_adapter.UpdateUsername(newUsername, oldUsername, password) == 1) return true;
            return false;
        }
    }
}
