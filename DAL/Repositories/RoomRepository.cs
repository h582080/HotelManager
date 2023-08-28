using DAL.DataContext;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public class RoomRepository: IRoomRepository
    {
        private HotelContext context;

        public RoomRepository(HotelContext context)
        {
            this.context = context;
        }

        public async Task<List<Room>> GetRooms()
        {
            return await  context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoomByID(int id)
        {
            return await context.Rooms.FindAsync(id);
        }

        public  void InsertRoom(Room room)
        {
            context.Rooms.Add(room);
        }

        public  void DeleteRoom(int roomID)
        {
            Room room = context.Rooms.Find(roomID);
            if(room != null)
            {
                context.Rooms.Remove(room);

            }
        }

        public void UpdateRoom(Room room)
        {
            var entity = context.Rooms.Find(room.RoomId);
            context.Entry(entity).State = EntityState.Detached;
            context.Entry(room).State = EntityState.Modified;
        }

        public   void Save()
        {
             context.SaveChanges();
        }



        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

