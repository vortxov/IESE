using System.ComponentModel.DataAnnotations;

namespace IESE.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введите почту")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [UIHint("password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
