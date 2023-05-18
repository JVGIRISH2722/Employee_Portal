using Employee_Portal.Data;
using Employee_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employee_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login obj)
        {
            if (obj == null)
            {
                ModelState.AddModelError("Name", "Enter UserName and Password");
                return View();
            }
            var UserFromDb = _db.Logins.Find(obj.UserName);
            if (UserFromDb == null)
            {
                ModelState.AddModelError("Name", "Employee is Not Existed in the Portal");
                return View();
            }
            if (obj.Password == UserFromDb.Password && ModelState.IsValid)
            {
                TempData["success"] = "Login Successful";
                return RedirectToAction("Employee_Details_Hr", "Hr");
            }
            else
            {
                ViewData["ValidPassword"] = "false";
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(Login obj)
        {
            Console.WriteLine(obj.UserName);
            if (obj == null)
            {
                ModelState.AddModelError("CustomError","Enter UserName and Password");
                return View();
            }
            var UserFromDb = _db.Employees.Where(p => p.Mail == obj.UserName);
            Console.WriteLine(UserFromDb);
            if (UserFromDb == null)
            {
                ModelState.AddModelError("Name", "Not Existing Employee");
                return View();
            }
            if (ModelState.IsValid && UserFromDb != null)
            {
                _db.Logins.Add(obj);
                ViewData["UserCreated"] = "true";
                _db.SaveChanges();

            }
            else
            {
                ViewData["ValidPassword"] = "false";
                
            }
            return RedirectToAction("Login");
            }



        }
}