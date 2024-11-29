using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeePortal.Models;

namespace EmployeePortal.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(string id);
        Task<IEnumerable<Employee>> SearchEmployeesByFirstNameAsync(string firstName);
        Task DeleteEmployeeAsync(string id);
        Task AddEmployeeAsync(Employee employee);
    }
}
