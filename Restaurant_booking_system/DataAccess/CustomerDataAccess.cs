using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system.DataAccess
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>
    internal class CustomerDataAccess : ICustomerDataAccess
    {
        private RestaurantDataSetTableAdapters.customersTableAdapter _adapter;
        public CustomerDataAccess()
        {
            _adapter = new RestaurantDataSetTableAdapters.customersTableAdapter();
        }

        public customersDataTable GetAll()
        {
            return _adapter.GetData();
        }

        public customersDataTable Search(string username, string password)
        {
            var data = _adapter.GetDataByUsernameAndPassword(username, password);
            if (data.Count() <= 0)
            {
                return null;
            }
            else
            {
                return data;
            }
        }
        public void UpdateUsername(string new_username, string old_username, string id)
        {
            _adapter.UpdateUsername(new_username, old_username, id);
        }

        public void UpdatePassword(string new_password, string old_password, string username)
        {
            _adapter.UpdatePassword(new_password, username, old_password);
        }

        public void Delete(string username, string password)
        {
            _adapter.DeleteAccount(username, password);
        }

        public bool Insert(User new_customer)
        {
            if (_adapter.Insert(new_customer.Firstname, new_customer.Lastname, new_customer.Username, new_customer.Password, new_customer.Email) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
