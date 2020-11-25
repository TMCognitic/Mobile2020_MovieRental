using MovieRental.Models.Client.Entities;
using MovieRental.Models.Client.Mappers;
using MovieRental.Models.Common.Interfaces;
using GlobalCustomer = MovieRental.Models.Global.Entities.Customer;


namespace MovieRental.Models.Client.Repositories
{
    public class AuthRepository : IAuthRepository<Customer>
    {
        private IAuthRepository<GlobalCustomer> _repository;

        public AuthRepository(IAuthRepository<GlobalCustomer> repository)
        {
            _repository = repository;
        }

        public Customer Login(string email, string passwd)
        {
            return _repository.Login(email, passwd)?.ToClient();
        }

        public void Register(Customer entity)
        {
            _repository.Register(entity.ToGlobal());
        }
    }
}
