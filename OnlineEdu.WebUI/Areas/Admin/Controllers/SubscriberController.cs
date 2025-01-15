using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.SubscriberDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SubscriberController : Controller
    {
        private readonly HttpClient _client;

        public SubscriberController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSubscriberDto>>("subscribers");
            return View(values);
        }

        public async Task<IActionResult> DeleteSubscriber(int id)
        {
            await _client.DeleteAsync($"subscribers/{id}");
            return RedirectToAction(nameof(Index));
        }

       
        public async Task<IActionResult> ChangeStatusSubscriber(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateSubscriberDto>($"Subscribers/{id}");
            if (value.IsActive)
            {
                value.IsActive = false;
            }
            else
            {
                value.IsActive = true;
            }
          
            await _client.PutAsJsonAsync("Subscribers", value);

            return RedirectToAction("Index");
        }

       
    }
}
