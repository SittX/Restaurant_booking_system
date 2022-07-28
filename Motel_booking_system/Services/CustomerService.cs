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
        private Motel_booking_system.BookingDataSetTableAdapters.adminTableAdapter _adminAdapter;
        public CustomerService()
        {
            _adapter = new Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter();
            _adminAdapter = new Motel_booking_system.BookingDataSetTableAdapters.adminTableAdapter();
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
                var customerDt = _adapter.GetDataByUsername(username);
                var adminDt = _adminAdapter.GetDataByUsername(username);
                var count = customerDt.Count;
                var count2 = adminDt.Count;
                if (customerDt.Count > 0 || adminDt.Count > 0)
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
                var id = Customer.GenerateId(_adapter.GetData());
                var password = newCus.Password;

                string encryptedPassword = PasswordEncryption.Encrypt(password);


                if (_adapter.InsertNewCustomerAcc(
                                  id,
                                  newCus.Username,
                                  encryptedPassword,
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

        public bool UpdatePassword(string newPassword, string oldPassword, string userId)
        {
            try
            {
                string encryptedNewPassword = PasswordEncryption.Encrypt(newPassword);


                if (_adapter.UpdatePassword(encryptedNewPassword, userId, oldPassword) == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                OutputMessage.ErrorMessage(ex.Message);
                return false;
            }

        }

        public bool UpdateUsername(string newUsername, string oldUsername, string password,string userId)
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
