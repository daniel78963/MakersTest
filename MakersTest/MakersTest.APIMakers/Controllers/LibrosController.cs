using MakersTest.APIMakers.Data.Entities;
using MakersTest.APIMakers.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersTest.APIMakers.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LibrosController : ControllerBase
    {
        private readonly ILibrosRepository librosRepository;

        public LibrosController(ILibrosRepository librosRepository)
        {
            this.librosRepository = librosRepository;
        }

        [HttpGet]
        public IActionResult GetLibros()
        {
            IEnumerable<Libro> lst = librosRepository.GetAll();
            return Ok(librosRepository.GetAll());
        }
    }
}
