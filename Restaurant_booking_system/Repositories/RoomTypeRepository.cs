using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Repositories
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly room_typesTableAdapter _adapter;

        public RoomTypeRepository(room_typesTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public room_typesDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count() <= 0 && data is null)
            {
                return new room_typesDataTable();
            }
            return data;
        }

        public bool Insert(string description)
        {
            if (_adapter.InsertNewRoomType(description) == 1) return true;
            return false;
        }


        public bool Delete(int typeId)
        {
            if (_adapter.DeleteRoomType(typeId) == 1) return true;
            return false;
        }

        public bool Update(string oldDescription, string newDescription)
        {
            if (_adapter.UpdateRoomType(newDescription, oldDescription) == 1) return true;
            return false;
        }
    }
}
