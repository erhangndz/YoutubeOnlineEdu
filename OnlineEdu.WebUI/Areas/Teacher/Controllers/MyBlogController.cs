using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI.DTOs.BlogDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class MyBlogController(UserManager<AppUser> _userManager) : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = await _client.GetFromJsonAsync<List<ResultBlogDto>>("blogs/GetBlogByWriterId/"+user.Id);
            return View(values);
        }
    }
}
