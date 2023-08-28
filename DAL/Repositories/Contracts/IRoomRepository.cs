using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public interface IRoomRepository : IDisposable
    {

        Task<List<Room>> GetRooms();
        Task<Room> GetRoomByID(int roomId);
        void  InsertRoom(Room room);
        void DeleteRoom(int roomId);
        void UpdateRoom(Room room);
        void Save();
    }
}
