using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Global.Entities;
using MovieRental.Models.Global.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Connection;

namespace MovieRental.Models.Global.Repositories
{
    public class LanguageRepository : ILanguageRepository<Language>
    {
        private readonly IConnection _connection;

        public LanguageRepository(IConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Language> Get()
        {
            Command command = new Command("MRSP_GetLanguages", true);
            return _connection.ExecuteReader(command, dr => dr.ToLanguage());
        }
    }
}
