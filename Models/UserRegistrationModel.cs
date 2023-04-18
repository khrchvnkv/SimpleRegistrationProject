using System.ComponentModel.DataAnnotations;

namespace SimpleRegistrationProject.Models
{
    public class UserRegistrationModel
    {
        public int Id { get; set; }
        
        [Display(Name = nameof(Name))]
        [Required(ErrorMessage = $"Enter {nameof(Name)}")]
        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }
        
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
        
        [Display(Name = nameof(ConfirmPassword))]
        [UIHint("Password")]
        [Required(ErrorMessage = $"Enter {nameof(ConfirmPassword)}")]
        [Compare(nameof(Password), 
            ErrorMessage = $"{nameof(ConfirmPassword)} doesn't match {nameof(Password)}")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = nameof(Age))]
        [Range(17, 120)]
        public int? Age { get; set; }
        
        [Display(Name = "Do you agree with the terms of the agreement?")]
        [Required(ErrorMessage = "Tap on checkbox")]
        public bool IsAgree { get; set; }
    }
}