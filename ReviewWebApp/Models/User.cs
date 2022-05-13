using System.ComponentModel.DataAnnotations;

namespace ReviewWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter a name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0} length must be between {2} and {1}")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Enter an email")]
        [EmailAddress] 
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} length must be between {2} and {1}")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm password")]
        [Compare("Password", ErrorMessage= "Passwords do not match")]
        public string? PasswordConfirm { get; set; }
    }
}
