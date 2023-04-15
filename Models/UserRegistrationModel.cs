namespace SimpleRegistrationProject.Models
{
    public class UserRegistrationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassrord { get; set; }
        public int Age { get; set; }
        public bool IsAgree { get; set; }
    }
}