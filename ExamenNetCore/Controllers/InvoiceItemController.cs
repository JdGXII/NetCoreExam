using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceItemController : ControllerBase
    {
        private readonly IRepository<InvoiceItem> _repository;
        public InvoiceItemController(IRepository<InvoiceItem> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceItem>>> GetInvoiceItems()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<InvoiceItem>> PostInvoiceItem(InvoiceItem InvoiceItem)
        {
            await _repository.Create(InvoiceItem);
            return Ok(InvoiceItem.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutInvoiceItem(InvoiceItem InvoiceItem)
        {
            var response = await _repository.Update(InvoiceItem);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteInvoiceItem(int id)
        {
            var response = await _repository.Delete(new InvoiceItem { Id = id });
            return Ok(response);
        }
    }
}
