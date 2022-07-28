
using Motel_booking_system.Helpers;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using static Motel_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Services
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>


    public class AdminService : IAdminService
    {
        private Motel_booking_system.BookingDataSetTableAdapters.adminTableAdapter _adapter;
        private Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter _customerAdapter;
        public AdminService()
        {
            _adapter = new Motel_booking_system.BookingDataSetTableAdapters.adminTableAdapter();
            _customerAdapter = new Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter();
        }



        public bool Delete(string username, string password)
        {
            string encryptedPassword = PasswordEncryption.Encrypt(password);
            if (_adapter.DeleteAccount(username, encryptedPassword) == 1) return true;
            return false;
        }

        public adminDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data is not null)
            {
                return data;
            }
            return new adminDataTable();
        }

        public bool Insert(Administrator newAdmin)
        {
            try
            {
                if (newAdmin is null)
                {
                    return false;
                }

                var id = Administrator.GenerateId(_adapter.GetData());
                var password = newAdmin.Password;

                string encryptedPassword = PasswordEncryption.Encrypt(password);


                if (_adapter.InsertNewAccount(
                    id,
                    newAdmin.Username,
                    encryptedPassword,
                    newAdmin.Permission) == 1)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public adminDataTable? Search(string username, string password)
        {

            var data = _adapter.GetDataByUsernameAndPassword(username, password);
            if (data.Count() < 1 && data is null)
            {
                return new adminDataTable();
            }
            return data;
        }

        public bool CheckDuplicateUsername(string username)
        {
            try
            {
                var adminDt = _adapter.GetDataByUsername(username);
                var customerDt = _customerAdapter.GetDataByUsername(username);
                var count = adminDt.Count;
                var count2 = customerDt.Count;
                if (adminDt.Count > 0 || customerDt.Count > 0)
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

    }
}
