using Restaurant_booking_system.BookingDataSetTableAdapters;
using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant_booking_system.BookingDataSet;

namespace Restaurant_booking_system.Repositories
{
    public class RoomsRepository : IRoomsRepository
    {
        private readonly roomsTableAdapter _adapter;

        public RoomsRepository(roomsTableAdapter adapter)
        {
            _adapter = adapter;
        }

        public roomsDataTable GetAll()
        {
            var data = _adapter.GetData();
            if (data.Count() <= 0 && data is null)
            {
                return new roomsDataTable();
            }
            return data;
        }

        public bool Insert(int roomNumber, int roomType, string description)
        {
            if (_adapter.InsertNewRoom(roomNumber, roomType, description) == 1) return true;
            return false;
        }

        public bool Delete(int roomNumber)
        {
            if (_adapter.DeleteRoom(roomNumber) == 1) return true;
            return false;
        }

        // Will implement it later
        public bool Update(int roomNumber, Room updatedRoom)
        {
            return false;
        }

    }
}
