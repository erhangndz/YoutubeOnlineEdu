namespace OnlineEdu.WebUI.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
