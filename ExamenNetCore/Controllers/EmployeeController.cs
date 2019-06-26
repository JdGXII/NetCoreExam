using Examen.Api.Repository;
using Exman.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee> _repository;
        public EmployeeController(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            var list = await _repository.Read();
            return Ok(list);
        } 

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            await _repository.Create(employee);
            return Ok(employee.Id);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutEmployee(Employee employee)
        {
            var response = await _repository.Update(employee);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteEmployee(int id)
        {
            var response = await _repository.Delete(new Employee { Id = id });
            return Ok(response);
        }
    }
}
