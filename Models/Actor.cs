using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movie_eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Profile Picture is required.")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The name must be between 3 and 50 characters.")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required.")]
        public string Bio { get; set; }
        // Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
