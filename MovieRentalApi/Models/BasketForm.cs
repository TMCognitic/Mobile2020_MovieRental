using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApi.Models
{
    public class BasketForm
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public IEnumerable<int> FilmIds { get; set; }
    }
}
