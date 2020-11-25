using MovieRental.Models.Client.Entities;
using MovieRentalApi.Models;

namespace MovieRentalApi.Infrastructure.Security
{
    public interface ITokenService
    {
        string GenerateToken(Customer customer);
        ApiCustomer ValidateToken(string token);
    }
}