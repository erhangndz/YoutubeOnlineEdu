

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.UserDtos
{
    public class UserRegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Şifreler birbiri ile uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
