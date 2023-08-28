using BLL.Services;
using CustomerWebAp.Models;
using CustomerWebApp.Models;
using CustomerWebApp.Utilities;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BLL.Services.Contracts;

namespace CustomerWebAp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService _customerService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _customerService = new CustomerService();
        }
        [Authentication]
            public IActionResult Index()
            {
                return View();
            }
        [Authentication]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Login");
        }
        

        // Get Action
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //Post Action
        [HttpPost]
        public async Task<IActionResult> Login([Bind] LoginModel model)
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                if (ModelState.IsValid)
                {
                   
                        Customer obj = await _customerService.Login(model.Username, model.Password);
                        if (obj != null)
                        {
                            HttpContext.Session.SetString("UserId", obj.CustomerId.ToString());
                        return RedirectToAction("Index");
                       }
                    
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] Customer customer)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _customerService.InsertCustomer(customer);
                    LoginModel loginModel = new LoginModel();
                    loginModel.Username = customer.Username;
                    loginModel.Password = customer.Password;
                    return await  Login(loginModel);
                   

                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessages = "Username Alread Exists!";
                }
               
            }


            return View(customer);
        }

        [Authentication]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}