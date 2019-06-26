using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _repository;
        public CustomerController(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return Ok(await _repository.Read());
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            await _repository.Create(customer);
            return Ok(customer.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutCustomer(Customer customer)
        {
            return Ok(await _repository.Update(customer));
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteCustomer(int id)
        {
            return Ok(await _repository.Delete(new Customer { Id = id }));
        }
    }
}
