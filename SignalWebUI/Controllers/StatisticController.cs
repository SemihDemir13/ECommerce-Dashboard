using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
