using Microsoft.AspNetCore.Mvc;

namespace Employee_Portal.Controllers
{
    public class Tech_Manager : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
