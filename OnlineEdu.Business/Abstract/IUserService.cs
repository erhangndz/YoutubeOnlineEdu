using Microsoft.AspNetCore.Identity;
using OnlineEdu.DTO.DTOs.UserDtos;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(RegisterDto userRegisterDto);

        Task<string> LoginAsync(LoginDto userLoginDto);
        Task LogoutAsync();

        Task<bool> CreateRoleAsync(UserRoleDto userRoleDto);

        Task<bool> AssignRoleAsync(List<AssignRoleDto> assignRoleDto);
        Task<List<AppUser>> GetAllUsersAsync();

        Task<List<ResultUserDto>> Get4Teachers();

        Task<AppUser> GetUserByIdAsync(int id);

        Task<int> GetTeacherCount();

        Task<List<ResultUserDto>> GetAllTeachers();
    }
}
