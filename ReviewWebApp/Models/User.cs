using System.ComponentModel.DataAnnotations;

namespace ReviewWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter a name")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Enter an email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Enter a confirm password")]
        public string? ConfirmPassword { get; set; }
    }
}
