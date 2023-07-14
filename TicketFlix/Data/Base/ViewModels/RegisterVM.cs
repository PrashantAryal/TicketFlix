using System.ComponentModel.DataAnnotations;

namespace TicketFlix.Data.ViewModels
{
        public class RegisterVM
        {
            [Display(Name = "Full name")]
            [Required(ErrorMessage = "Full name is required")]
            public string? FullName { get; set; }

            [Display(Name = "Email address")]
            [Required(ErrorMessage = "Email address is required")]
            public string? EmailAddress { get; set; }

            
            [Required]
            [DataType(DataType.Password)]
            [RegularExpression(@"^(?=.*[A-Z])(?=.*\W).+$", ErrorMessage = "Password must include an Uppercase letter and a special character")]
            public string? Password { get; set; }

            [Display(Name = "Confirm password")]
            [Required(ErrorMessage = "Confirm password is required")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Passwords do not match")]
            public string? ConfirmPassword { get; set; }
        }
    }
