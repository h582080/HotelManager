using BLL.Services;
using CustomerWebApp.Models;
using CustomerWebApp.Utilities;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CustomerWebApp.Controllers
{
    [Authentication]
    public class ReservationController : Controller
    {
        ReservationService _reservationService;

        public ReservationController()
        {
            _reservationService = new ReservationService();
        }

        public async Task<IActionResult> Index()
        {
            var idstring = HttpContext.Session.GetString("UserId");
            var reservations = new List<Reservation>();
            if (idstring != null)
            { 
                reservations = await _reservationService.GetReservationsByCustomer(int.Parse(idstring));
                
            }
            return View(reservations);
        }

        public IActionResult Create(string roomDetails,DateTime initStart, DateTime initEnd)
        {
            var roomReservationViewModel = JsonConvert.DeserializeObject<RoomReservationViewModel>(roomDetails);
            
            if  (roomReservationViewModel == null)
            {
                
                System.Diagnostics.Debug.WriteLine("null ID " ) ;
                return NotFound();
            } else
            {
                roomReservationViewModel.CustomerId = int.Parse(HttpContext.Session.GetString("UserId"));
                roomReservationViewModel.StartOn = initStart;
                roomReservationViewModel.EndOn = initEnd;
                System.Diagnostics.Debug.WriteLine("Room id  "+roomReservationViewModel.RoomId);
                return View(roomReservationViewModel);
            }
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] RoomReservationViewModel roomReservation)
         {
         
            if (ModelState.IsValid)
            {
                Reservation res = new Reservation();
                try
                {
                    res.CustomerId = roomReservation.CustomerId;
                    res.RoomId = roomReservation.RoomId; ;
                    res.CheckedIn = false;
                    res.Status = "Requested";
                    res.StartOn = roomReservation.StartOn;
                    res.EndOn = roomReservation.EndOn;
                    System.Diagnostics.Debug.WriteLine("user ID " + res.CustomerId);
                    _reservationService.InsertReservation(res);
                    return RedirectToAction("index", "Reservation");
                }
                catch 
                {
                    ViewBag.Errors ="You already have a reservation for this room. please check your reservation status";

                }
                
            }
                
            
            return View(roomReservation);
        }

      
    }
}
