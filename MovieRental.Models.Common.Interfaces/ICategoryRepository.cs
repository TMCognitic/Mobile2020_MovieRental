using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Common.Interfaces
{
    public interface ICategoryRepository <TEntity>
    {
        IEnumerable<TEntity> Get();
    }
}
