using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistTrackController : ControllerBase
    {
        private readonly IRepository<PlaylistTrack> _repository;
        public PlaylistTrackController(IRepository<PlaylistTrack> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlaylistTrack>>> GetPlaylistTracks()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<PlaylistTrack>> PostPlaylistTrack(PlaylistTrack PlaylistTrack)
        {
            await _repository.Create(PlaylistTrack);
            return Ok(PlaylistTrack.PlaylistId);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutPlaylistTrack(PlaylistTrack PlaylistTrack)
        {
            var response = await _repository.Update(PlaylistTrack);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeletePlaylistTrack(int id)
        {
            var response = await _repository.Delete(new PlaylistTrack { PlaylistId = id });
            return Ok(response);
        }
    }
}
