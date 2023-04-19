using System.ComponentModel.DataAnnotations;

namespace SimpleRegistrationProject.Models
{
    public class UserRegistrationModel : UserLoginModel
    {
        public int Id { get; set; }
        
        [Display(Name = nameof(Name))]
        [Required(ErrorMessage = $"Enter {nameof(Name)}")]
        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }

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