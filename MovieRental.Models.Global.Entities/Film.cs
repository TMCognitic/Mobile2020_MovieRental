using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Global.Entities
{
    public class Film
    {
        public int FilmId { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public int ReleaseYear { get; set; } 
        public string Language { get; set; } 
        public int RentalDuration { get; set; } 
        public decimal RentalPrice { get; set; } 
        public int Length { get; set; } 
        public decimal ReplacementCost { get; set; } 
        public string Rating { get; set; }
    }
}
