using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Global.Entities
{
    public class Rental
    {
        public int CustomerId { get; set; }
        public int[] FilmIds { get; set; }
    }
}
