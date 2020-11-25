using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Common.Interfaces
{
    public interface IAuthRepository<TEntity>
    {
        void Register(TEntity entity);
        TEntity Login(string email, string passwd);
    }
}
