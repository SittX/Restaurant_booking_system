using Motel_booking_system.Helpers;
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
        public CustomerService()
        {
            _adapter = new Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter();
        }

        public bool Delete(string username, string password)
        {
            try
            {
                if (_adapter.DeleteAccount(username, password) == 1) return true;

                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

        }

        public customersDataTable GetAll()
        {
            var data = _adapter.GetData();

            if (data.Count() <= 0 && data is null)
            {
                return new customersDataTable();
            }
            return new customersDataTable();
        }

        public bool CheckDuplicateUsername(string username)
        {
            try
            {
                var dt = _adapter.GetDataByUsername(username);
                var count = dt.Count;
                if (dt.Count > 0 && dt is not null)
                {
                    OutputMessage.WarningMessage("Username already exists. Please try again.");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }
        }

        public bool Insert(Customer newCus)
        {

            try
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
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

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
            try
            {
                var data = _adapter.GetDataById(id);

                if (data.Count() <= 0 && data is null)
                {
                    return new customersDataTable();
                }
                return data;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return new customersDataTable();
            }

        }

        public bool UpdatePassword(string newPassword, string oldPassword, string username)
        {
            try
            {
                if (_adapter.UpdatePassword(newPassword, username, oldPassword) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

        }

        public bool UpdateUsername(string newUsername, string oldUsername, string password)
        {
            try
            {
                if (_adapter.UpdateUsername(newUsername, oldUsername, password) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

        }
    }
}
