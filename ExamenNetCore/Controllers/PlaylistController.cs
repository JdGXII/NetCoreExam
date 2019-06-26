using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistController : ControllerBase
    {
        private readonly IRepository<Playlist> _repository;
        public PlaylistController(IRepository<Playlist> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Playlist>>> GetPlaylists()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<Playlist>> PostPlaylist(Playlist Playlist)
        {
            await _repository.Create(Playlist);
            return Ok(Playlist.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutPlaylist(Playlist Playlist)
        {
            var response = await _repository.Update(Playlist);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeletePlaylist(int id)
        {
            var response = await _repository.Delete(new Playlist { Id = id });
            return Ok(response);
        }
    }
}
