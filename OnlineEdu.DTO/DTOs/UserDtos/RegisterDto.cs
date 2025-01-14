using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.UserDtos
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Şifreler birbiri ile uyumlu değil")]
        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
