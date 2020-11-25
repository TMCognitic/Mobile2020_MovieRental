using MovieRental.Models.Common.Interfaces;
using MovieRental.Models.Global.Entities;
using MovieRental.Models.Global.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Connection;

namespace MovieRental.Models.Global.Repositories
{
    public class AuthRepository : IAuthRepository<Customer>
    {
        private readonly IConnection _connection;

        public AuthRepository(IConnection connection)
        {
            _connection = connection;
        }

        public Customer Login(string email, string passwd)
        {
            Command command = new Command("MRSP_CheckCustomer", true);
            command.AddParameter("Email", email);
            command.AddParameter("Passwd", passwd);

            return _connection.ExecuteReader(command, dr => dr.ToCustomer()).SingleOrDefault();
        }

        public void Register(Customer entity)
        {
            Command command = new Command("MRSP_RegisterCustomer", true);
            command.AddParameter("LastName", entity.LastName);
            command.AddParameter("FirstName", entity.FirstName);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("Passwd", entity.Passwd);

            _connection.ExecuteNonQuery(command);
        }
    }
}
