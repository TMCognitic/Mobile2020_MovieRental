using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Global.Entities;
using MovieRental.Models.Global.Repositories.Mappers;
using System;
using System.Collections.Generic;
using Tools.Connection;

namespace MovieRental.Models.Global.Repositories
{
    public class ActorRepository : IActorRepository<Actor>
    {
        private readonly IConnection _connection;

        public ActorRepository(IConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Actor> Get()
        {
            Command command = new Command("MRSP_GetActors", true);
            return _connection.ExecuteReader(command, dr => dr.ToActor());
        }

        public IEnumerable<Actor> GetByInitial(char initial)
        {
            Command command = new Command("MRSP_GetActorsByInitial", true);
            command.AddParameter("Initial", initial);

            return _connection.ExecuteReader(command, dr => dr.ToActor());
        }

        public IEnumerable<Actor> GetByFilm(int filmId)
        {
            Command command = new Command("MRSP_GetActorsByFilm", true);
            command.AddParameter("FilmId", filmId);

            return _connection.ExecuteReader(command, dr => dr.ToActor());
        }

        public IEnumerable<string> GetInitials()
        {
            Command command = new Command("MRSP_GetActorInitials", true);

            return _connection.ExecuteReader(command, dr => (string)dr["Initial"]);
        }
    }
}
