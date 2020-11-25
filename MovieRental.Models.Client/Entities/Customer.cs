using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Client.Entities
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Email { get; private set; }
        public string Passwd { get; private set; }

        public Customer(string lastName, string firstName, string email, string passwd)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Passwd = passwd;
        }

        internal Customer(int customerId, string lastName, string firstName, string email)
            : this(lastName, firstName, email, null)
        {
            CustomerId = customerId;
        }
    }
}
