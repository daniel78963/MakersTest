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

        [HttpPost]
        public async Task<IActionResult> PostLibro([FromBody] Libro Libro)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var newLibro = await this.librosRepository.CreateAsync(Libro);
            return Ok(newLibro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibro([FromRoute] int id, [FromBody] Libro Libro)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (id != Libro.IdLibro)
            {
                return BadRequest();
            }

            var oldLibro = await this.librosRepository.GetByIdAsync(id);
            if (oldLibro == null)
            {
                return this.BadRequest("Libro no existe.");
            }

            oldLibro.Titulo = Libro.Titulo;
            oldLibro.Fecha = Libro.Fecha;
            oldLibro.Costo = Libro.Costo;
            oldLibro.PrecioSugerido = Libro.PrecioSugerido;
            oldLibro.Autor = Libro.Autor;
            oldLibro.Editorial = Libro.Editorial;

            var updatedLibro = await this.librosRepository.UpdateAsync(oldLibro);
            return Ok(updatedLibro);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibro([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var Libro = await this.librosRepository.GetByIdAsync(id);
            if (Libro == null)
            {
                return this.NotFound();
            }

            await this.librosRepository.DeleteAsync(Libro);
            return Ok(Libro);
        }
    }
}
