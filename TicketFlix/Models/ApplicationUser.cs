using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TicketFlix.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "FullName")]
        public string? FullName { get; set; }
    }
}
