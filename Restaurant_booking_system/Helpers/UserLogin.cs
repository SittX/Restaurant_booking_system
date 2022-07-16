using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Helpers
{
    public class UserLogin
    {

        private adminDataTable _adminDt = new adminDataTable();
        private customersDataTable _userDt = new customersDataTable();

        private readonly ICustomerRepository _customerRepo;
        private readonly IAdminRepository _adminRepo;

        public UserLogin(ICustomerRepository customerRepo, IAdminRepository adminRepo)
        {
            _customerRepo = customerRepo;
            _adminRepo = adminRepo;
        }

        /// <summary>
        /// This func authenticate if the account exists or not .
        /// If it exists , it will assign the return data table to private variables "_users" or "_admins"
        /// </summary>
        /// <returns> If user exists , return TRUE. Else return FALSE. </returns>
        public bool LoginUser(string username, string password)
        {
            var users = _customerRepo.Search(username, password);
            var admins = _adminRepo.Search(username, password);
            if (users is not null && admins is not null)
            {
                _userDt = users;
                _adminDt = admins;
            }

            if (_userDt.Count() > 0 || _adminDt.Count() > 0)
            {
                SaveSessionOwner();
                return true;
            }
            else
            {
                MessageBox.Show("User not found", "Warning");
                return false;
            }
        }

        /// <summary>
        /// This func save the currently logged in user account into "SessionInfo" class 
        /// </summary>
        /// <returns></returns>
        private void SaveSessionOwner()
        {
            if (_userDt.Count() > 0 && _userDt is not null)
            {
                Customer currentUser = new Customer()
                {
                    Id = _userDt[0]["id"].ToString(),
                    Username = _userDt[0]["username"].ToString(),
                    Password = _userDt[0]["acc_password"].ToString(),
                    Email = _userDt[0]["email"].ToString(),
                    PhoneNumber = _userDt[0]["ph_number"].ToString(),
                    NRC = _userDt[0]["NRC"].ToString()
                };

                Session.Session.LoggedInUser = currentUser;
                Session.Session.IsUser = true;
            }
            else if (_adminDt.Count() > 0 && _adminDt is not null)
            {

                Administrator currentUser = new Administrator()
                {
                    Id = _adminDt[0]["id"].ToString(),
                    Username = _adminDt[0]["username"].ToString(),
                    Password = _adminDt[0]["acc_password"].ToString(),
                    Permission = _adminDt[0]["permission"].ToString()
                };

                Session.Session.LoggedInAdmin = currentUser;
                Session.Session.IsAdmin = true;
            }
        }

        /// <summary>
        /// Save currently logged in user to "SessionInfo" class
        /// </summary>
        /// <param name="obj"></param>
        //private void SaveUser(object obj)
        //{ 

        //    if (obj.GetType() == typeof(Customer))
        //    {
        //        Session.Session.LoggedInUser = obj as Customer;
        //    }
        //    else
        //    {
        //        Session.Session.LoggedInAdmin = obj as Administrator;
        //    }
        //}

    }
}
