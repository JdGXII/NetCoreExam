using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
            private readonly IRepository<Album> _repository;
            public AlbumController(IRepository<Album> repository)
            {
                _repository = repository;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
            {
                var list = await _repository.Read();
                return Ok(list);
            }

            [HttpPost]
            public async Task<ActionResult<Album>> PostAlbum(Album request)
            {
                await _repository.Create(request);
                return Ok(request.Id);
            }

            [HttpPut]
            public async Task<ActionResult<bool>> PutAlbum(Album album)
            {
                var response = await _repository.Update(album);
                return Ok(response);
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult<bool>> DeleteAlbum(int id)
            {
                var response = await _repository.Delete(new Album { Id = id });
                return Ok(response);
            }
    }
}
