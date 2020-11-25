using Microsoft.AspNetCore.Mvc;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;
using MovieRentalApi.Infrastructure.Security;
using MovieRentalApi.Models;

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository<Customer> _repository;
        private readonly ITokenService _tokenService;

        public AuthController(ITokenService tokenService, IAuthRepository<Customer> repository)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        // POST api/auth/legister
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginForm form)
        {
            if(ModelState.IsValid)
            {
                Customer customer = _repository.Login(form.Email, form.Passwd);

                if (customer is null)
                    return NoContent();

                ApiCustomer apiCustomer = new ApiCustomer(customer);
                apiCustomer.Token = _tokenService.GenerateToken(customer);

                return Ok(apiCustomer);
            }

            return BadRequest();
        }

        // POST api/auth/register
        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterForm form)
        {
            if (ModelState.IsValid)
            {
                _repository.Register(new Customer(form.LastName, form.FirstName, form.Email, form.Passwd));
                return Ok();
            }

            return BadRequest();
        }
    }
}
