using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.SubscriberDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(CreateSubscriberDto model)
        {
            await _client.PostAsJsonAsync("subscribers", model);
            return NoContent();
        }



    }
}
