using BLL.Models;

namespace BLL.Services.Contracts
{
    public interface IRoomService 
    {

        Task<List<Room>> GetRooms();
        Task<Room> GetRoomByID(int roomId);
        void InsertRoom(Room room);
        void DeleteRoom(int roomId);
        void UpdateRoom(Room room);
        Task<List<Room>> FindRoomBy(RoomQuery roomQuery);

    }
}
