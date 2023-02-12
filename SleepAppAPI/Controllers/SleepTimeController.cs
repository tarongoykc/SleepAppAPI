using Microsoft.AspNetCore.Mvc;

namespace SleepAppAPI.Controllers
{
    public class SleepTimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
