using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaTypeController : ControllerBase
    {
        private readonly IRepository<MediaType> _repository;
        public MediaTypeController(IRepository<MediaType> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MediaType>>> GetMediaTypes()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<MediaType>> PostMediaType(MediaType MediaType)
        {
            await _repository.Create(MediaType);
            return Ok(MediaType.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutMediaType(MediaType MediaType)
        {
            var response = await _repository.Update(MediaType);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteMediaType(int id)
        {
            var response = await _repository.Delete(new MediaType { Id = id });
            return Ok(response);
        }
    }
}
