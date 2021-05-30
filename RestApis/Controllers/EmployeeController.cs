using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApis.Models;
using RestApis.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees); 
        }

        //GET: api/Employee/5
        [HttpGet ("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound("Couldn't Found Employee Record");
            }
            return Ok(employee);
        }

        //Post: api/Employee
        [HttpPost]
        public IActionResult post([FromBody] Employee employee)
        {
            
            if (employee == null)
            {
                return BadRequest("Employee field is Null");
            }
            _dataRepository.Add(employee);
            return CreatedAtRoute(
                "Get",
                new { Id = employee.EmployeeId },
                employee);
        }


        //PUT: api/Employee/5
        [HttpPatch("{id}")]
        public IActionResult Patch(long id, [FromBody] Employee employee)
        {
            
            if (employee == null)
            {
                return BadRequest("Couldn't Found Employee Record");
            }
            Employee employeeToUpdate = _dataRepository.Get(id);
            if (employeeToUpdate == null)
            {
                return NotFound("couldn't found Employee Record");

            }
            _dataRepository.Update(employeeToUpdate, employee);
            return Ok(employeeToUpdate);
        }

        //DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Employee employee = _dataRepository.Get(id);

            if (employee == null)
            {
                return NotFound("Couldn't Found Employee Record");
            }
            _dataRepository.Delete(employee);
            return Ok();
        }





    }
}
