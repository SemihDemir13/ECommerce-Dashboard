using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
