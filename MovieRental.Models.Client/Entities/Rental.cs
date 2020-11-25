using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Client.Entities
{
    public class Rental
    {
        public int CustomerId { get; private set; }
        public IEnumerable<int> FilmIds { get; private set; }

        public Rental(int customerId, IEnumerable<int> filmIds)
        {
            CustomerId = customerId;
            FilmIds = filmIds;
        }
    }
}
