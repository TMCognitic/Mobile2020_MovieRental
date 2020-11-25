using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Client.Entities
{
    public class Film
    {      
        public int FilmId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Language { get; private set; }
        public int RentalDuration { get; private set; }
        public decimal RentalPrice { get; private set; }
        public int Length { get; private set; }
        public decimal ReplacementCost { get; private set; }
        public string Rating { get; private set; }

        public Film(int filmId, string title, string description, int releaseYear, string language, int rentalDuration, decimal rentalPrice, int length, decimal replacementCost, string rating)
        {
            FilmId = filmId;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Language = language;
            RentalDuration = rentalDuration;
            RentalPrice = rentalPrice;
            Length = length;
            ReplacementCost = replacementCost;
            Rating = rating;
        }
    }
}
