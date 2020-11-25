using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;
using MovieRentalApi.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthRequired]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository<Category> _repository;
        public CategoryController(ICategoryRepository<Category> repository)
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
