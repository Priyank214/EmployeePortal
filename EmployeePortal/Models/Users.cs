using Microsoft.AspNetCore.Identity;

namespace EmployeePortal.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
