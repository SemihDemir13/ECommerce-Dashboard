using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
