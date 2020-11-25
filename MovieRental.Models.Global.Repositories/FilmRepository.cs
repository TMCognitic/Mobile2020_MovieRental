using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Global.Entities;
using MovieRental.Models.Global.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Connection;

namespace MovieRental.Models.Global.Repositories
{
    public class FilmRepository : IFilmRepository<Film>
    {
        private readonly IConnection _connection;

        public FilmRepository(IConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Film> Get()
        {
            Command command = new Command("MRSP_GetFilms", true);
            return _connection.ExecuteReader(command, dr => dr.ToFilm());
        }

        public IEnumerable<Film> GetByActor(int actorId)
        {
            Command command = new Command("MRSP_GetFilmsByActor", true);
            command.AddParameter("ActorId", actorId);
            return _connection.ExecuteReader(command, dr => dr.ToFilm());
        }

        public IEnumerable<Film> GetByCategory(int categoryId)
        {
            Command command = new Command("MRSP_GetCategory", true);
            command.AddParameter("CategoryId", categoryId);
            return _connection.ExecuteReader(command, dr => dr.ToFilm());
        }

        public IEnumerable<Film> GetByKeyword(string keyword)
        {
            Command command = new Command("MRSP_GetFilmsByKeyword", true);
            command.AddParameter("Keyword", keyword);
            return _connection.ExecuteReader(command, dr => dr.ToFilm());
        }

        public IEnumerable<Film> GetByLanguage(int languageId)
        {
            Command command = new Command("MRSP_GetFilmsByLanguage", true);
            command.AddParameter("LanguageId", languageId);
            return _connection.ExecuteReader(command, dr => dr.ToFilm());
        }

        public IEnumerable<Film> GetByTitle(string title)
        {
            Command command = new Command("MRSP_GetFilmByTitle", true);
            command.AddParameter("Title", title);
            return _connection.ExecuteReader(command, dr => dr.ToFilm());
        }
    }
}
