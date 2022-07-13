namespace Restaurant_booking_system.Interfaces
{
    public interface IRoomTypeRepository
    {
        bool Delete(int typeId);
        BookingDataSet.room_typesDataTable GetAll();
        bool Insert(string description);
        bool Update(string oldDescription, string newDescription);
    }
}