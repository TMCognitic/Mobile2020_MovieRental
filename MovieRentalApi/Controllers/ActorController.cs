using Microsoft.AspNetCore.Mvc;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;
using MovieRentalApi.Infrastructure.Attributes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//Récupérer les initiales des noms des acteurs
//Récupérer la liste des acteurs (complet, par initiale, par film)

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthRequired]
    public class ActorController : ControllerBase
    {
        private readonly IActorRepository<Actor> _repository;

        public ActorController(IActorRepository<Actor> repository)
        {
            _repository = repository;
        }

        // GET: api/<ActorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet("ByInitial/{initial}")]
        public IActionResult Get(char initial)
        {
            return Ok(_repository.GetByInitial(initial));
        }

        [HttpGet("ByFilm/{filmId}")]
        public IActionResult Get(int filmId)
        {
            return Ok(_repository.GetByFilm(filmId));
        }

        [HttpGet("Initials")]
        public IActionResult GetInitials()
        {
            return Ok(_repository.GetInitials());
        }
    }
}
