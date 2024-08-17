using Microsoft.AspNetCore.Identity;
using OnlineEdu.WebUI.DTOs.UserDtos;

namespace OnlineEdu.WebUI.Services.UserServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(UserRegisterDto userRegisterDto);

        Task<bool> LoginAsync(UserLoginDto userLoginDto);
        Task<bool> LogoutAsync();

        Task<bool> CreateRoleAsync(UserRoleDto userRoleDto);

        Task<bool> AssignRoleAsync(AssignRoleDto assignRoleDto);

    }
}
