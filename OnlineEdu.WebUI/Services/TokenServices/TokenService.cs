using System.Security.Claims;

namespace OnlineEdu.WebUI.Services.TokenServices
{
    public class TokenService : ITokenService
    {
        private readonly IHttpContextAccessor _contextAccessor;

       

        public TokenService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetUserToken => _contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Token")?.Value;

        public int GetUserId => int.Parse(_contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        public string GetUserRole => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

        public string GetUserNameSurname => _contextAccessor.HttpContext.User.FindFirst("fullName")?.Value;
    }
}
