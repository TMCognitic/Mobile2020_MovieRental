using GlobalCategory = MovieRental.Models.Global.Entities.Category;

using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using MovieRental.Models.Client.Mappers;

namespace MovieRental.Models.Client.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        readonly ICategoryRepository<GlobalCategory> _repository;

        public CategoryRepository(ICategoryRepository<GlobalCategory> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Category> Get()
        {
            return _repository.Get().Select(c => c.ToClient());
        }
    }
}
