using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Common.Interfaces
{
    public interface IRentalRepository<TEntity>
    {
        int Create(TEntity entity);
    }
}
