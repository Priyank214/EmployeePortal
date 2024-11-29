using EmployeePortal.Models;
using EmployeePortal.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeePortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            var employees = await _employeeRepository.GetAllEmployeesAsync();
            return employees.Count() > 0 ? Ok(employees): NotFound();
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Employee>>> SearchEmployeesByFirstName([FromQuery] string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return BadRequest("First name query parameter is required.");
            }

            var employees = await _employeeRepository.SearchEmployeesByFirstNameAsync(firstName);
            return employees.Count() > 0 ? Ok(employees) : NotFound();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            await _employeeRepository.DeleteEmployeeAsync(id);
            return Ok(employee);
        }
    }
}
