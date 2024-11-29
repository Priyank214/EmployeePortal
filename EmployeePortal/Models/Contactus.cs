using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Contactus
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; }

        public string Query { get; set; }

        public string MobileNo { get; set; }

        public bool Resolved { get; set; } = false;
    }
}
