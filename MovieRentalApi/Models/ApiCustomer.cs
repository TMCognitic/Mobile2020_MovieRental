using MovieRental.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApi.Models
{
    public class ApiCustomer
    {
        public int CustomerId { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Email { get; private set; }
        public string Token { get; internal set; }

        public ApiCustomer(Customer customer)
        {
            CustomerId = customer.CustomerId;
            LastName = customer.LastName;
            FirstName = customer.FirstName;
            Email = customer.Email;
        }

        public ApiCustomer(int customerId, string lastName, string firstName, string email)
        {
            CustomerId = customerId;
            LastName = lastName;
            FirstName = firstName;
            Email = email;
        }
    }
}
