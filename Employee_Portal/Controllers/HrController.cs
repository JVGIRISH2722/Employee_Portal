using Employee_Portal.Data;
using Employee_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Portal.Controllers
{
    public class HrController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HrController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Employee_Details_Hr()
        {
            IEnumerable<Employee> objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create_Employee_Hr()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create_Employee_Hr(Employee Obj)
        {
            _db.Employees.Add(Obj);
            _db.SaveChanges();
            TempData["success"] = "Employee Added Successfully";
            return RedirectToAction("Employee_Details_Hr");
        }
    }
}
