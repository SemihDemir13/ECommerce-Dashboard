using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
