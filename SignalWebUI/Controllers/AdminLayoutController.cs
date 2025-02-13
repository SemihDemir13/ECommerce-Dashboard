using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
