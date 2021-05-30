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
    public class EmployeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public EmployeController(IDataRepository<Employee> dataRepository)
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
                return NotFound("Employee field is Null");
            }
            _dataRepository.Add(employee);
            return CreatedAtRoute(
                "Get",
                new { Id = employee.EmployeeId },
                employee);
        }


    }
}
