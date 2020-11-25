using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Global.Entities;
using MovieRental.Models.Global.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Connection;

namespace MovieRental.Models.Global.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        private readonly IConnection _connection;

        public CategoryRepository(IConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Category> Get()
        {
            Command command = new Command("MRSP_GetCategories", true);
            return _connection.ExecuteReader(command, dr => dr.ToCategory());
        }
    }
}
