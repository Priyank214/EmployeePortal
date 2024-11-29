using EmployeePortal.Models;

namespace EmployeePortal.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(Contactus contactus);
    }
}
