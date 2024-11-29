using EmployeePortal.Models;
using EmployeePortal.Repositories;
using EmployeePortal.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmployeePortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusController : ControllerBase
    {
        private readonly IMailService _mailService;
        private readonly IContactusRepository _contactusRepository;

        public ContactusController(IMailService mailService, IContactusRepository contactusRepository)
        {
            _mailService = mailService;
            _contactusRepository = contactusRepository;
        }

        
        [HttpPost]
        public async Task<IActionResult> SubmitContactForm([FromForm] Contactus contactus)
        {
            if (contactus == null || string.IsNullOrEmpty(contactus.Email) || string.IsNullOrEmpty(contactus.Query))
            {
                return BadRequest("Invalid contact form data.");
            }

       
            try
            {
                // Send email to support or admin
                await _mailService.SendEmailAsync(contactus); 

                
                await _contactusRepository.AddContactusAsync(contactus);

                return RedirectToAction("ThankYou", "Home");
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
