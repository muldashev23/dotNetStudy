using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [EmailAddress(ErrorMessage = "Provide Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public string UserName { get; set; }
    }
}
