using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

        return View(); 
        }
    }
}
