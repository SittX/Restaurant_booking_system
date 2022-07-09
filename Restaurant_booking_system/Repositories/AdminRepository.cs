using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_booking_system.RestaurantDataSet;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Interfaces;

namespace Restaurant_booking_system.Repositories
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>

   
    
    public class AdminRepository : IAdminRepository
    {
        private RestaurantDataSetTableAdapters.administratorsTableAdapter adapter;
        public AdminRepository()
        {
            adapter = new RestaurantDataSetTableAdapters.administratorsTableAdapter();
        }


        public administratorsDataTable GetAll()
        {
            var data = adapter.GetData();
            if(data.Count() > 0)
            {
                return data ;
            }
            return new administratorsDataTable();
        }
        
        public administratorsDataTable? Search(string username, string password)
        {
            var data = adapter.GetDataByUsernameAndPwd(username, password);
            if (data.Count() > 0)
            {
                return data;
            }
            return null;
        }

        
        public bool Insert(Administrator new_admin)
        {
            if (adapter.Insert(new_admin.Username, new_admin.Password) == 1) return true;
            return false;
        }

        public bool Update(int id, Administrator updatedAccount, Administrator originalAccount)
        {
            if(adapter.UpdateAccount(updatedAccount.Username, updatedAccount.Password, id, originalAccount.Username, originalAccount.Password) == 1)return true;
            return false;
        }

        public bool Delete(int id,string password)
        {
            if(adapter.DeleteAccount(id,password) == 1) return true;
            return false;
        }
    }
}
