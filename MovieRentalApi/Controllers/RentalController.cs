using Microsoft.AspNetCore.Mvc;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;
using MovieRentalApi.Infrastructure.Attributes;
using MovieRentalApi.Models;

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthRequired]
    public class RentalController : ControllerBase
    {
        private readonly IRentalRepository<Rental> _repository;
        public RentalController(IRentalRepository<Rental> repository)
        {
            _repository = repository;
        }

        // POST api/<RentalController>
        [HttpPost]
        public IActionResult Post([FromBody] BasketForm form)
        {
            int customerId = (int)ControllerContext.RouteData.Values["CustomerId"];

            if (customerId == form.CustomerId)
            {
                return Ok(_repository.Create(new Rental(form.CustomerId, form.FilmIds)));
            }

            return BadRequest(new { Error = "Invalid Token" });
        }
    }
}
