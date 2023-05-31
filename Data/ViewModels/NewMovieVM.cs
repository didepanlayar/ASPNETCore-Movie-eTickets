using Movie_eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movie_eTickets.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }
        [Display(Name = "Movie Image")]
        [Required(ErrorMessage = "Image is required.")]
        public string ImageURL { get; set; }
        [Display(Name = "Start")]
        [Required(ErrorMessage = "Start is required.")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Finish")]
        [Required(ErrorMessage = "Finish is required.")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Movie Category")]
        [Required(ErrorMessage = "Category is required.")]
        public MovieCategory MovieCategory { get; set; }
        // Relationship
        [Display(Name = "Actors")]
        [Required(ErrorMessage = "Actors is required.")]
        public List<int> ActorIds { get; set; }
        // Cinema
        [Display(Name = "Cinema")]
        [Required(ErrorMessage = "Cinema is required.")]
        public int CinemaId { get; set; }
        // Producer
        [Display(Name = "Producer")]
        [Required(ErrorMessage = "Producer is required.")]
        public int ProducerId { get; set; }
    }
}
