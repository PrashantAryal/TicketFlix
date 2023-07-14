using System.ComponentModel.DataAnnotations;
using TicketFlix.Data.Base;

namespace TicketFlix.Models
{
    public class Actor : IEntityBase

    {
        [Key]   //data annotation to uniquely identify for this class and also for table rows in the database

        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string? DpURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Name must be between 3 to 50 chars")]
        public string? Name { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string? Biography { get; set; }


        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }

}