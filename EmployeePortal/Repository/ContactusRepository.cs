using EmployeePortal.Data;
using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeePortal.Repositories
{
    public class ContactusRepository : IContactusRepository
    {
        private readonly AppDbContext _context;

        public ContactusRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddContactusAsync(Contactus contactus)
        {
            await _context.Contactus.AddAsync(contactus);
            await _context.SaveChangesAsync();
        }
    }
}
