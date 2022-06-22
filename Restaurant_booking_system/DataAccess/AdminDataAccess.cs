using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_booking_system.RestaurantDataSet;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Interfaces;

namespace Restaurant_booking_system.DataAccess
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>

   
    
    internal class AdminDataccess : IAdminDataccess
    {
        private RestaurantDataSetTableAdapters.administratorsTableAdapter adapter;
        public AdminDataccess()
        {
            adapter = new RestaurantDataSetTableAdapters.administratorsTableAdapter();
        }


        public administratorsDataTable GetAll()
        {
            return adapter.GetData();
        }
        
        public administratorsDataTable Search(string username, string password)
        {
            var data = adapter.GetDataByUsernameAndPwd(username, password);
            if (data is not null)
            {
                return data;
            }
            else
            {
                return new administratorsDataTable();
            }
        }

        
        public bool Insert(Administrator new_admin)
        {
            if (adapter.Insert(new_admin.Username, new_admin.Password) == 1) return true;
            return false;
        }

        public void Update(int id, Administrator updatedAccount, Administrator originalAccount)
        {
            adapter.UpdateAccount(updatedAccount.Username, updatedAccount.Password, id, originalAccount.Username, originalAccount.Password);
        }

        public void Delete(int id,string password)
        {
            adapter.DeleteAccount(id,password);
        }
    }
}
