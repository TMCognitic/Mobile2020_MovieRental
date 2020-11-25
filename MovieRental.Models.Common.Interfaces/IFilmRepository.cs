using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Common.Interfaces
{
    public interface IFilmRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> GetByCategory(int categoryId);
        IEnumerable<TEntity> GetByActor(int actorId);
        IEnumerable<TEntity> GetByTitle(string title);
        IEnumerable<TEntity> GetByLanguage(int languageId);
        IEnumerable<TEntity> GetByKeyword(string keyword);
    }
}
