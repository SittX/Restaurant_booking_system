namespace Restaurant_booking_system.Interfaces
{
    public interface IRoomTypeRepository
    {
        bool Delete(string description);
        BookingDataSet.room_typesDataTable GetAll();
        bool Insert(string description);
        bool Update(string oldDescription, string newDescription);
    }
}