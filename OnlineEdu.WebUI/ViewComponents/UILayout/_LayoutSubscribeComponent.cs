using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI.ViewComponents.UILayout
{
    public class _LayoutSubscribeComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
