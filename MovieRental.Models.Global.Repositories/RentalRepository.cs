using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tools.Connection;

namespace MovieRental.Models.Global.Repositories
{
    public class RentalRepository : IRentalRepository<Rental>
    {
        private readonly IConnection _connection;

        public RentalRepository(IConnection connection)
        {
            _connection = connection;
        }

        public int Create(Rental entity)
        {
            Command command = new Command("MRSP_CreateRental", true);
            command.AddParameter("CustomerId", entity.CustomerId);

            DataTable filmIds = new DataTable();
            filmIds.Columns.Add("FilmId", typeof(int));

            foreach(int filmId in entity.FilmIds)
            {
                filmIds.Rows.Add(filmId);
            }
            command.AddParameter("FilmIds", filmIds);

            return (int)_connection.ExecuteScalar(command);
        }
    }
}
