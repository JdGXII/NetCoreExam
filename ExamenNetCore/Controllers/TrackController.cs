using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackController : ControllerBase
    {
        private readonly IRepository<Track> _repository;
        public TrackController(IRepository<Track> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Track>>> GetTracks()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<Track>> PostTrack(Track Track)
        {
            await _repository.Create(Track);
            return Ok(Track.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutTrack(Track Track)
        {
            var response = await _repository.Update(Track);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteTrack(int id)
        {
            var response = await _repository.Delete(new Track { Id = id });
            return Ok(response);
        }
    }
}
