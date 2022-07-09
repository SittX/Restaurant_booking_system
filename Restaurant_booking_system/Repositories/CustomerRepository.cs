using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_booking_system.RestaurantDataSet;

namespace Restaurant_booking_system.Repositories
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>
    internal class CustomerRepository : ICustomerRepository
    {
        private RestaurantDataSetTableAdapters.customersTableAdapter _adapter;
        public CustomerRepository()
        {
            _adapter = new RestaurantDataSetTableAdapters.customersTableAdapter();
        }

        public customersDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count() > 0 && data is not null)
            {
                return data;
            }
            return new customersDataTable();
        }

        public customersDataTable? Search(string username, string password)
        {
            var data = _adapter.GetDataByUsernameAndPassword(username, password);
            if (data.Count() > 0 && data is not null)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public customersDataTable SearchById(int id)
        {
            var data = _adapter.GetDataById(id);
            if(data.Count() > 0 && data is not null)
            {
                return data;
            }
            return new customersDataTable();
        }

        public bool UpdateUsername(string new_username, string old_username, string password)
        {
            if (_adapter.UpdateUsername(new_username,password,old_username) == 1) return true;
            return false;
        }

        public bool UpdatePassword(string new_password, string old_password, string username)
        {
            if (_adapter.UpdatePassword(new_password, username, old_password) == 1) return true;

            return false;
        }

        public bool Delete(string username, string password)
        {
            if (_adapter.DeleteAccount(username, password) == 1) return true;

            return false;
        }

        public bool Insert(User new_customer)
        {
            if (_adapter.Insert(new_customer.Firstname, new_customer.Lastname, new_customer.Username, new_customer.Password, new_customer.Email) == 1) return true;
            return false;
        }
    }
}
