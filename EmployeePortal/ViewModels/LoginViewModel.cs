using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
