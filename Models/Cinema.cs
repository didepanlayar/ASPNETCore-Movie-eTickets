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
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        // Relationship
        public List<Movie> Movies { get; set; }
    }
}
