using Movie_eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movie_eTickets.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Picture is required.")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The name must be between 3 and 50 characters.")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        // Relationship
        public List<Movie> Movies { get; set; }
    }
}
