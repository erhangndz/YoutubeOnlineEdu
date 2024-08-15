using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.Models;
using System.Diagnostics;

namespace OnlineEdu.WebUI.Controllers
{
    public class HomeController : Controller
    {    
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
