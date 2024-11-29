using EmployeePortal.Data;
using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all employees
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

      
        public async Task<Employee> GetEmployeeByIdAsync(string id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        // Search employees by First Name
        public async Task<IEnumerable<Employee>> SearchEmployeesByFirstNameAsync(string firstName)
        {
            return await _context.Employees
                .Where(e => e.FirstName.Contains(firstName))
                .ToListAsync();
        }

        // Delete employee
        public async Task DeleteEmployeeAsync(string id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        // Add employee future task
        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
    }
}
