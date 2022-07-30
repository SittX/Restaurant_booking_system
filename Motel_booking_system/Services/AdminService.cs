﻿using Motel_booking_system.Helpers;
using Motel_booking_system.Interfaces;
using Motel_booking_system.Models;
using static Motel_booking_system.BookingDataSet;
namespace Motel_booking_system.Services
{
    public class AdminService : IAdminService
    {
        private Motel_booking_system.BookingDataSetTableAdapters.adminTableAdapter _adapter;
        private Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter _customerAdapter;
        public AdminService()
        {
            _adapter = new Motel_booking_system.BookingDataSetTableAdapters.adminTableAdapter();
            _customerAdapter = new Motel_booking_system.BookingDataSetTableAdapters.customersTableAdapter();
        }


        #region Service methods
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
            catch (InvalidDataException ie)
            {
                Console.WriteLine($"Error message: {ie.Message}");
                OutputMessage.ErrorMessage("Invalid data. Please try again");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage("Account cannot be created. Please try again.");
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
                Console.WriteLine($"Error message: {ex.Message}");
                OutputMessage.ErrorMessage("Account cannot not be created. Please try again.");
                return false;
            }
        } 
        #endregion

    }
}
