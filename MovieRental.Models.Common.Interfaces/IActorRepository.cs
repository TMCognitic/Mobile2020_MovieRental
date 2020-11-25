using System;
using System.Collections.Generic;

namespace MovieRental.Models.Common.Interfaces
{
    public interface IActorRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> GetByInitial(char initiale);
        IEnumerable<TEntity> GetByFilm(int filmId);
        IEnumerable<string> GetInitials();
    }
}
