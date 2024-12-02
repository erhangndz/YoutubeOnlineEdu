using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI.Areas.Student.Controllers
{
    [Area("Student")]
    public class StudentLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
