using EmployeePortal.Models;
using System.Threading.Tasks;

namespace EmployeePortal.Repositories
{
    public interface IContactusRepository
    {
        Task AddContactusAsync(Contactus contactus);
    }
}
