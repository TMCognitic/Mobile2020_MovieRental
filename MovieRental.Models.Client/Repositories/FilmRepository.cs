using GlobalFilm = MovieRental.Models.Global.Entities.Film;

using MovieRental.Models.Client.Entities;
using MovieRental.Models.Client.Mappers;
using MovieRental.Models.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MovieRental.Models.Client.Repositories
{
    public class FilmRepository : IFilmRepository<Film>
    {
        private readonly IFilmRepository<GlobalFilm> _repository;

        public FilmRepository(IFilmRepository<GlobalFilm> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Film> Get()
        {
            return _repository.Get().Select(f => f.ToClient());
        }

        public IEnumerable<Film> GetByActor(int actorId)
        {
            return _repository.GetByActor(actorId).Select(f => f.ToClient());
        }

        public IEnumerable<Film> GetByCategory(int categoryId)
        {
            return _repository.GetByCategory(categoryId).Select(f => f.ToClient());
        }

        public IEnumerable<Film> GetByKeyword(string keyword)
        {
            return _repository.GetByKeyword(keyword).Select(f => f.ToClient());
        }

        public IEnumerable<Film> GetByLanguage(int languageId)
        {
            return _repository.GetByLanguage(languageId).Select(f => f.ToClient());
        }

        public IEnumerable<Film> GetByTitle(string title)
        {
            return _repository.GetByTitle(title).Select(f => f.ToClient());
        }
    }
}
