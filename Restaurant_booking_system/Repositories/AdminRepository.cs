
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Repositories
{
    /// <summary>
    ///  This class will contains all the CRUD operations between the application and the SQL server
    /// </summary>


    public class AdminRepository : IAdminRepository
    {
        private BookingDataSetTableAdapters.adminTableAdapter _adapter;
        public AdminRepository(BookingDataSetTableAdapters.adminTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public bool Delete(string username, string password)
        {
            if (_adapter.DeleteAccount(username, password) == 1) return true;
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

                if (_adapter.InsertNewAccount(
                    newAdmin.Id,
                    newAdmin.Username,
                    newAdmin.Password) == 1)
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

    }
}
