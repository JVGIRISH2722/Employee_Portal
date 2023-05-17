using Employee_Portal.Data;
using Employee_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Portal.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Employee_Details()
        {
            IEnumerable<Employee> objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }
        public IActionResult Create_Employee()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create_Employee(Employee Obj)
        {
            _db.Employees.Add(Obj); 
            _db.SaveChanges();
            TempData["success"] = "Employee Added Successfully";
            return RedirectToAction("Employee_Details");
        }
        public IActionResult Employee_Edit(int id, string Skill)
        {
            if (id == 0 || Skill == "")
            {
                return NotFound();
            }
            var EmployeeDetails = _db.Employees.Find(id);
            
            //var categoryFromDbFirst = _db.Categories.FirstOrDefault();
            if (EmployeeDetails == null)
            {
                return NotFound();
            }
            return View(EmployeeDetails);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Employee_Edit(Employee Obj)
        {
                _db.Employees.Update(Obj);
                _db.SaveChanges();
                TempData["success"] = "Skill Added Successfully";
                return RedirectToAction("Employee_Details");
       
        }

        
    }
}
