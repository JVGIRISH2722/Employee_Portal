using Employee_Portal.Data;
using Employee_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Portal.Controllers
{
    public class Tech_ManagerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public Tech_ManagerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employee_Details_Tr()
        {
            IEnumerable<Employee> objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }
        public IActionResult Skill_Details_Tr()
        {
            IEnumerable<Skill_Id> objEmployeeList = _db.Skill_Ids;
            return View(objEmployeeList);
        }
        public IActionResult Create_Skill_Tr()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create_Skill_Tr(Skill_Id Obj)
        {
            _db.Add(Obj);
            _db.SaveChanges();
            TempData["success"] = "Skill Added Successfully";
            return RedirectToAction("Skill_Details_Tr");
        }
    }
}
