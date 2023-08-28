using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public interface IReservationRepository : IDisposable
    {


        Task<List<Reservation>> GetReservations();
        Task<Reservation> GetReservationByID(int reservationId);
        void InsertReservation(Reservation reservation);
        void DeleteReservation(int customerId, int roomId);
        void UpdateReservation(Reservation reservation);

        Task<List<Reservation>> GetReservationsByRoom(int roomId);
        void Save();
    }
}
