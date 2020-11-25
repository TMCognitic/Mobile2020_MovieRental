using System;

namespace MovieRental.Models.Client.Entities
{
    public class Actor
    {
        public int ActorId { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }

        internal Actor(int actorId, string lastName, string firstName)
        {
            ActorId = actorId;
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
