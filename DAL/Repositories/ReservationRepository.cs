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
    public class ReservationRepository : IReservationRepository , IDisposable
    {
        private HotelContext context;

        public ReservationRepository(HotelContext context)
        {
            this.context = context;
        }

        public async Task<List<Reservation>> GetReservations()
        {
            return await context.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetReservationByID(int id)
        {
            return await context.Reservations.FindAsync(id);
        }

        public void InsertReservation(Reservation reservation)
        {
            context.Reservations.Add(reservation);
        }

        public void DeleteReservation(int customerId, int roomId)
        {
            Reservation reservation = context.Reservations.Where(r => r.RoomId == roomId && r.CustomerId ==customerId).FirstOrDefault();
            context.Reservations.Remove(reservation);
        }

        public void UpdateReservation(Reservation reservation)
        {
            var entity = context.Reservations.Where(r => r.RoomId == reservation.RoomId && r.CustomerId == reservation.CustomerId).FirstOrDefault();
            context.Entry(entity).State = EntityState.Detached;
            context.Entry(reservation).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task<List<Reservation>> GetReservationsByRoom(int roomId)
        {
            return await context.Reservations.Where(r => r.RoomId == roomId).ToListAsync();

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
