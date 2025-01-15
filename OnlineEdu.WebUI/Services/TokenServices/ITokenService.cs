namespace OnlineEdu.WebUI.Services.TokenServices
{
    public interface ITokenService
    {

        public string GetUserToken { get; }
        public int GetUserId { get; }
        public string GetUserRole { get; }
        public string GetUserNameSurname { get; }
    }
}
