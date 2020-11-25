using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Common.Interfaces
{
    public interface ILanguageRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
    }
}
