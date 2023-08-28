using AutoMapper;
using BLL.Models;
using BLL.Services.Contracts;
using DAL.DataContext;
using DAL.Repositories.Contracts;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class RoomService : IRoomService 
    {
        private HotelContext _context;
        private IRoomRepository _roomRepository;
        private IReservationRepository _reservationRepository;
        private Mapper _mapper;
        public RoomService()
        {
            _context = new HotelContext();
            this._roomRepository = new RoomRepository(_context);
            this._reservationRepository = new ReservationRepository(_context);
            var _config = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Models.Room, Room>().ReverseMap());
            _mapper = new Mapper(_config);
        }

        public async  Task<List<Room>> GetRooms()
        {
            return  _mapper.Map<List<DAL.Models.Room>, List<Room>> (await _roomRepository.GetRooms());
        }

        public async Task<Room> GetRoomByID(int id)
        {
            return _mapper.Map<DAL.Models.Room,Room>(await _roomRepository.GetRoomByID(id));
        }

        public  void InsertRoom(Room room)
        {
            try
            {
                var r = _mapper.Map<Room, DAL.Models.Room>(room);
                 _roomRepository.InsertRoom(r);
                _roomRepository.Save();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteRoom(int id)
        {
            try
            {
                _roomRepository.DeleteRoom(id);
                _roomRepository.Save();
            }
            catch
            {
                throw;
            }

        }

        public void UpdateRoom(Room room)
        {
            try
            {
                var r = _mapper.Map<Room, DAL.Models.Room>(room);
                _roomRepository.UpdateRoom(r);
                _roomRepository.Save();
            }
            catch
            {
                throw;
            }

        }

        public async Task<List<Room>> FindRoomBy(RoomQuery roomQuery)
        {
            List<Room> queryResults = new List<Room>();

            var predicate = PredicateBuilder.New<Room>(true);
            //Expression<Func<Room, bool>> predicate

            if (!string.IsNullOrEmpty(roomQuery.RoomOccupancy) && roomQuery.RoomOccupancy != "All")
            {
                predicate = predicate.And(r => r.Occupancy == roomQuery.RoomOccupancy);
            }
            if (!string.IsNullOrEmpty(roomQuery.RoomLayout) && roomQuery.RoomLayout != "All")
            {
                predicate = predicate.And(r => r.Layout == roomQuery.RoomLayout);
            }
         
              predicate = predicate.And(r => r.Beds >= roomQuery.BedsMin && r.Beds <= roomQuery.BedsMax);
              predicate = predicate.And(r => r.Price >= roomQuery.PriceMin && r.Price<= roomQuery.PriceMax);

            var rooms =  _mapper.Map<List<DAL.Models.Room>, List<Room>>(await _roomRepository.GetRooms());
            var  requestedRooms = rooms.Where(predicate).ToList();
            foreach (var r in requestedRooms)
            {
                var roomResrvations = await _reservationRepository.GetReservationsByRoom(r.RoomId);
                if(roomResrvations != null)
                {
                    var res = roomResrvations.Where(
                        re => 
                        (re.StartOn <= roomQuery.StartOn && re.EndOn >= roomQuery.EndOn)
                        || 
                        (re.EndOn > roomQuery.StartOn && re.StartOn<roomQuery.StartOn)
                        ||
                        (re.StartOn < roomQuery.EndOn && re.StartOn > roomQuery.StartOn)
                        )
                        .Where(re => re.Status != "Finished").ToList();
                    if (res.Count == 0)
                    {
                        queryResults.Add(r);
                    }
                } else
                {
                    queryResults.Add(r);
                }
              
            }

            return queryResults;

        }

 
    }
}
