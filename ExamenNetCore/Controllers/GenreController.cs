using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IRepository<Genre> _repository;
        public GenreController(IRepository<Genre> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<Genre>> PostGenre(Genre genre)
        {
            await _repository.Create(genre);
            return Ok(genre.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutGenre(Genre genre)
        {
            var response = await _repository.Update(genre);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteGenre(int id)
        {
            var response = await _repository.Delete(new Genre { Id = id });
            return Ok(response);
        }
    }
}
