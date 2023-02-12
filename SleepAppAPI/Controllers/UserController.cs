using Microsoft.AspNetCore.Mvc;

namespace SleepAppAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
