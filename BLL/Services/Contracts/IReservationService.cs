using BLL.Models;

namespace BLL.Services.Contracts
{
    public interface IReservationService
    {

        Task<List<Reservation>> GetReservations();
        Task<Reservation> GetReservationByID(int reservationId);
        void InsertReservation(Reservation reservation);
        void DeleteReservation(int customerId, int roomId);
        void UpdateReservation(Reservation reservation);
        Task<List<CustomerReservation>> GetReservationsWithCustomers();

        Task<List<Reservation>> GetReservationsByCustomer(int customerId);
        Task<List<Reservation>> GetReservationsByRoom(int roomId);

        void InsertReservationWithUsername(Reservation reservation, string username);





    }
}
