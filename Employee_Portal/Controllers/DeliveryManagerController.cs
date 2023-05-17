using Employee_Portal.Data;
using Employee_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Portal.Controllers
{
    public class DeliveryManagerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DeliveryManagerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Employee_Details_Role()
        {
            IEnumerable<Employee> objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }
        public IActionResult Employee_Edit_Role(int id, string Role)
        {
            if (id == 0 || Role == "")
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
        public IActionResult Employee_Edit_Role(Employee Obj)
        {
            _db.Employees.Update(Obj);
            Console.WriteLine(Obj.Role);
            _db.SaveChanges();
            TempData["success"] = "Role Added Successfully";
            return RedirectToAction("Employee_Details_Role");

        }
    }
}
