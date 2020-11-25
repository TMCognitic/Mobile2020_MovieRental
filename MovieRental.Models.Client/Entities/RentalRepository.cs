using GlobalRental = MovieRental.Models.Global.Entities.Rental;

using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Client.Mappers;
using System;
using System.Collections.Generic;
using System.Text;


namespace MovieRental.Models.Client.Entities
{
    public class RentalRepository : IRentalRepository<Rental>
    {
        readonly IRentalRepository<GlobalRental> _repository;

        public RentalRepository(IRentalRepository<GlobalRental> repository)
        {
            _repository = repository;
        }

        public int Create(Rental entity)
        {
            return _repository.Create(entity.ToGlobal());
        }
    }
}
