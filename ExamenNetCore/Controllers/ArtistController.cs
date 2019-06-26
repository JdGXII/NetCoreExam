using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
        private readonly IRepository<Artist> _repository;
        public ArtistController(IRepository<Artist> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtists()
        {
            var list = await _repository.Read();
            return Ok(list);
        }


        [HttpPost]
        public async Task<ActionResult<Artist>> PostArtist(Artist artist)
        {
            await _repository.Create(artist);
            return Ok(artist.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutArtist(Artist artist)
        {
            var response = await _repository.Update(artist);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteArtist(int id)
        {
            var response = await _repository.Delete(new Artist { Id = id });
            return Ok(response);
        }
    }
}
