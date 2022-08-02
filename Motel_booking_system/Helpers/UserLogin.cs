using Motel_booking_system.Interfaces;
using Motel_booking_system.Models;
using static Motel_booking_system.BookingSystemDataSet;

namespace Motel_booking_system.Helpers
{
    public class UserLogin
    {

        private administratorsDataTable _adminDt = new administratorsDataTable();
        private customersDataTable _userDt = new customersDataTable();

        private readonly ICustomerService _customerService;
        private readonly IAdminService _adminService;

        public UserLogin(ICustomerService customerService, IAdminService adminService)
        {
            _customerService = customerService;
            _adminService = adminService;
        }

        /// <summary>
        /// This func authenticate if the account exists or not .
        /// If it exists , it will assign the return data table 
        /// </summary>
        /// <returns> If user exists , return TRUE. Else return FALSE. </returns>
        public bool LoginUser(string username, string password)
        {
            var users = _customerService.Search(username, password);
            var admins = _adminService.Search(username, password);

            if (users is not null && admins is not null)
            {
                _userDt = users;
                _adminDt = admins;
            }

            if (_userDt.Count > 0 || _adminDt.Count > 0)
            {
                SaveSessionOwner();
                return true;
            }
            else
            {
                OutputMessage.WarningMessage("User with the given username cannot be found.");
                return false;
            }
        }

        /// <summary>
        /// This func save the currently logged in user account into "SessionInfo" class 
        /// </summary>
        /// <returns></returns>
        private void SaveSessionOwner()
        {
            if (_userDt.Count > 0 && _userDt is not null)
            {
                Customer currentUser = new Customer()
                {
                    Id = _userDt[0]["id"].ToString(),
                    Username = _userDt[0]["username"].ToString(),
                    Password = _userDt[0]["acc_password"].ToString(),
                    Email = _userDt[0]["email"].ToString(),
                    PhoneNumber = _userDt[0]["ph_number"].ToString()
                };

                Session.CurrentSession.LoggedInUser = currentUser;
                Session.CurrentSession.IsUser = true;
            }
            else if (_adminDt.Count > 0 && _adminDt is not null)
            {

                Administrator currentUser = new Administrator()
                {
                    Id = _adminDt[0]["id"].ToString(),
                    Username = _adminDt[0]["username"].ToString(),
                    Password = _adminDt[0]["acc_password"].ToString(),
                    Permission = _adminDt[0]["permission"].ToString()
                };

                Session.CurrentSession.LoggedInAdmin = currentUser;
                Session.CurrentSession.IsAdmin = true;
            }
        }

    }
}
