using System.ComponentModel.DataAnnotations;
using TicketFlix.Data.Base;

namespace TicketFlix.Models
{
    public class Producer : IEntityBase

    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string? DpURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 to 50 chars")]
        public string? Name { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Biography { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}