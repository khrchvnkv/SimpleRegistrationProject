using System.ComponentModel.DataAnnotations;

namespace SimpleRegistrationProject.Models
{
    public class UserLoginModel
    {
        [Display(Name = nameof(Mail))]
        [Required(ErrorMessage = $"Enter {nameof(Mail)}")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]/w+)*\.\w+([-.]\w+)*$")]
        [EmailAddress]
        [UIHint("EmailAddress")]
        public string Mail { get; set; }
        
        [Display(Name = nameof(Password))]
        [Required(ErrorMessage = $"Enter {nameof(Password)}")]
        [UIHint("Password")]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
    }
}