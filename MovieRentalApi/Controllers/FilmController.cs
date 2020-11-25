using Microsoft.AspNetCore.Mvc;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;
using MovieRentalApi.Infrastructure.Attributes;
using MovieRentalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthRequired]
    public class FilmController : ControllerBase
    {
        readonly IFilmRepository<Film> _repository;

        public FilmController(IFilmRepository<Film> repository)
        {
            _repository = repository;
        }

        // GET: api/<FilmController>
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return _repository.Get();
        }

        [HttpGet("ByCategory/{categoryId}")]
        public IEnumerable<Film> GetByCategory(int categoryId)
        {
            return _repository.GetByCategory(categoryId);
        }

        [HttpGet("ByActor/{actorId}")]
        public IEnumerable<Film> GetByActor(int actorId)
        {
            return _repository.GetByActor(actorId);
        }

        [HttpPost("ByTitle")]
        public IEnumerable<Film> GetByTitle([FromBody] DataForm form)
        {
            return _repository.GetByTitle(form.Data);
        }

        [HttpGet("ByLanguage/{languageId}")]
        public IEnumerable<Film> GetByLanguage(int languageId)
        {
            return _repository.GetByLanguage(languageId);
        }

        [HttpPost("ByKeyWord")]
        public IEnumerable<Film> GetByKeyword([FromBody] DataForm form)
        {
            return _repository.GetByKeyword(form.Data);
        }
    }
}
