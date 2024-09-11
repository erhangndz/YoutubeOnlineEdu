using FluentValidation;
using OnlineEdu.WebUI.DTOs.BlogCategoryDtos;

namespace OnlineEdu.WebUI.Validators
{
    public class BlogCategoryValidator: AbstractValidator<CreateBlogCategoryDto>
    {
        public BlogCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog Kategori Adı Boş bırakılamaz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Blog Kategori Adı en fazla 30 karakter olmalıdır.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Blog Kategori Adı en az 3 karakter olmalıdır.");
        }
    }
}
