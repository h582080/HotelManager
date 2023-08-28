using BLL.Services;
using CustomerWebApp.Utilities;
using BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BLL.Services.Contracts;
using CustomerWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;

namespace CustomerWebApp.Controllers
{
    [Authentication]
    public class RoomController : Controller
    {
        IRoomService _roomService;

        public RoomController()
        {
            _roomService = new RoomService();
        }

        public  IActionResult Index()
        {
            RoomSearchModel rsModel = new RoomSearchModel();
            return View(rsModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind] RoomSearchModel roomSearchModel)
        {

            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("roomSearchModel   " + roomSearchModel.BedsMax);
                System.Diagnostics.Debug.WriteLine("roomSearchModel   " + roomSearchModel.BedsMin);
                var _config = new MapperConfiguration(cfg => cfg.CreateMap<RoomSearchModel, RoomQuery>().ReverseMap());
                Mapper _mapper = new Mapper(_config);
                RoomQuery rq = _mapper.Map<RoomQuery>(roomSearchModel);
                roomSearchModel.SearchResults = await _roomService.FindRoomBy(rq);

            }

            return View(roomSearchModel);
        }

        public async Task<IActionResult> Book(int id,DateTime start,DateTime end)
        {
            Room room = await _roomService.GetRoomByID(id);
            string roomDetails = JsonConvert.SerializeObject(room);
            System.Diagnostics.Debug.WriteLine("start " + start);
            return RedirectToAction("Create","Reservation", new {roomDetails = roomDetails, initStart = start,initEnd=end });
           
        }
    }
}
