using Microsoft.AspNetCore.Mvc;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;
using MovieRentalApi.Infrastructure.Attributes;
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
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepository<Language> _repository;
        public LanguageController(ILanguageRepository<Language> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }
    }
}
