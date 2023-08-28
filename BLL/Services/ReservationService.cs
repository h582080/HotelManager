using DAL.DataContext;
using BLL.Models;
using DAL.Repositories.Contracts;
using AutoMapper;
using BLL.Services.Contracts;

namespace BLL.Services
{
    public class ReservationService : IReservationService
    {
        private IReservationRepository _reservationRepository;
        private ICustomerRepository _customerRepository;
        private IRoomRepository _roomRepository;
        private HotelContext _context;
        private Mapper _mapper;

        public ReservationService()
        {
            _context = new HotelContext();
            this._reservationRepository = new ReservationRepository(_context);
            this._customerRepository = new CustomerRepository(_context);
            this._roomRepository = new RoomRepository(_context);
            var _config = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Models.Reservation, Reservation>().ReverseMap());
            _mapper = new Mapper(_config);
        }

        public async Task<List<Reservation>> GetReservations()
        {
            return _mapper.Map<List<DAL.Models.Reservation>, List<Reservation>>(await _reservationRepository.GetReservations());
        }

        public async Task<Reservation> GetReservationByID(int id)
        {
            return _mapper.Map<DAL.Models.Reservation, Reservation>(await _reservationRepository.GetReservationByID(id));
        }

        public void InsertReservation(Reservation reservation)
        {
            try
            {
                var r = _mapper.Map<Reservation, DAL.Models.Reservation>(reservation);
                _reservationRepository.InsertReservation(r);
                _reservationRepository.Save();
            }
            catch
            {
                throw;
            }
        }

        public async void InsertReservationWithUsername(Reservation reservation, string username)
        {
            try
            {
                var c =await  _customerRepository.GetCustomerByUsername(username);
                var r = _mapper.Map<Reservation, DAL.Models.Reservation>(reservation);
                r.CustomerId = c.CustomerId;
                _reservationRepository.InsertReservation(r);
                _reservationRepository.Save();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteReservation(int customerId, int roomId)
        {
            try
            {
                _reservationRepository.DeleteReservation(customerId,  roomId);
                _reservationRepository.Save();
            }
            catch
            {
                throw;
            }

        }

        public void UpdateReservation(Reservation reservation)
        {
            try
            {
                var r = _mapper.Map<Reservation, DAL.Models.Reservation>(reservation);
                _reservationRepository.UpdateReservation(r);
                _reservationRepository.Save();
            }
            catch
            {
                throw;
            }

        }

        public async Task<List<Reservation>> GetReservationRequests()
        {

            var requests = (await _reservationRepository.GetReservations()).Where(r => r.Status == "Requested").ToList();
            return _mapper.Map<List<DAL.Models.Reservation>, List<Reservation>>(requests);

        }

        public async Task<List<CustomerReservation>> GetReservationsWithCustomers()
        {
            //ToDO: move to DAL
            List<CustomerReservation> customerReservations = new List<CustomerReservation>();
            var customers = await _customerRepository.GetCustomers();
            var reservations =await  _reservationRepository.GetReservations();
            var rooms = await _roomRepository.GetRooms();
            customerReservations =
                 ( from c in customers
                  join r in reservations on c.CustomerId equals r.CustomerId
                   join ro in rooms
                   on r.RoomId equals ro.RoomId
                   select new CustomerReservation {
                          CustomerId=  c.CustomerId,
                          Username = c.Username,
                          FirstName = c.FirstName,
                          LastName =  c.LastName,
                          RoomId =  r.RoomId,
                          CheckedIn =  r.CheckedIn,
                          StartOn = r.StartOn,
                          EndOn = r.EndOn,
                          Status = r.Status,
                          RoomNumber = ro.RoomNumber,
                         }).ToList();
            return customerReservations;
    }
        
        public async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
        {
            //ToDO: move to DAL
            List<Reservation> reservations = new List<Reservation>();
            reservations =  _mapper.Map<List<DAL.Models.Reservation>, List<Reservation>>(await _reservationRepository.GetReservations());
            var customerReservations = reservations.Where(r => r.CustomerId == customerId).ToList();
            return customerReservations;
        }

       public async   Task<List<Reservation>> GetReservationsByRoom(int roomId)
        {
            return _mapper.Map<List<DAL.Models.Reservation>, List<Reservation>>(await _reservationRepository.GetReservationsByRoom(roomId));

        }

    }
}


