using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BlogCategoryDtos;
using OnlineEdu.WebUI.Helpers;
using OnlineEdu.WebUI.Models;

namespace OnlineEdu.WebUI.ViewComponents.Blog
{
    public class _BlogCategoryList: ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogCategories");

            var blogCategories = (from blogCategory in categoryList
                                  select new BlogCategoryWithCountViewModel
                                  {
                                      CategoryName = blogCategory.Name,
                                      BlogCount = blogCategory.Blogs.Count
                                  }).ToList();
            return View(blogCategories);
        }
    }
}
