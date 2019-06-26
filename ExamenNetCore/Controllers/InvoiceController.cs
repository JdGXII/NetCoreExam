using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IRepository<Invoice> _repository;
        public InvoiceController(IRepository<Invoice> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoices()
        {
            var list = await _repository.Read();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<Invoice>> PostInvoice(Invoice invoice)
        {
            await _repository.Create(invoice);
            return Ok(invoice.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutInvoice(Invoice invoice)
        {
            var response = await _repository.Update(invoice);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteInvoice(int id)
        {
            var response = await _repository.Delete(new Invoice { Id = id });
            return Ok(response);
        }
    }
}
