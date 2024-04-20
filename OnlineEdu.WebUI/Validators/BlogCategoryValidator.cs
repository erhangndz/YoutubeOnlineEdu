using FluentValidation;
using OnlineEdu.WebUI.DTOs.BlogCategoryDtos;

namespace OnlineEdu.WebUI.Validators
{
    public class BlogCategoryValidator: AbstractValidator<CreateBlogCategoryDto>
    {
        public BlogCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog Kategori Adı Boş bırakılamaz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Blog Kategori Adı en fazla 30 karakter ollmalıdır.");
        }
    }
}
