using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeBannerComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
