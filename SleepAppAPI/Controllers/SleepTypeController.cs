using Microsoft.AspNetCore.Mvc;

namespace SleepAppAPI.Controllers
{
    public class SleepTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
