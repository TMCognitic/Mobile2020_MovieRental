using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Client.Entities
{
    public class Category
    {
        public int CategoryId { get; private set; }
        public string Name { get; private set; }

        internal Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
}
