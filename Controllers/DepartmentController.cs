using Microsoft.AspNetCore.Mvc;

namespace Company.Wep.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
