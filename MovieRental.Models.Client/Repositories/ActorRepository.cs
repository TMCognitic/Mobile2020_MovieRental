using GlobalActor = MovieRental.Models.Global.Entities.Actor;

using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using MovieRental.Models.Client.Mappers;

namespace MovieRental.Models.Client.Repositories
{
    public class ActorRepository : IActorRepository<Actor>
    {
        readonly IActorRepository<GlobalActor> _repository;

        public ActorRepository(IActorRepository<GlobalActor> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Actor> Get()
        {
            return _repository.Get().Select(c => c.ToClient());
        }

        public IEnumerable<Actor> GetByFilm(int filmId)
        {
            return _repository.GetByFilm(filmId).Select(c => c.ToClient());
        }

        public IEnumerable<Actor> GetByInitial(char initiale)
        {
            return _repository.GetByInitial(initiale).Select(c => c.ToClient());
        }

        public IEnumerable<string> GetInitials()
        {
            return _repository.GetInitials();
        }
    }
}
