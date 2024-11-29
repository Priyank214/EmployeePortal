using System.Diagnostics;
using EmployeePortal.Models;
using EmployeePortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EmployeePortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<Users> _signInManager;
        private readonly UserManager<Users> _userManager;

        public HomeController(ILogger<HomeController> logger,SignInManager<Users> signInManager,UserManager<Users> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        [Authorize]
        public IActionResult Employees()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                
                TempData["Error"] = "Email or password is invalid.";
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                

                var result = await _signInManager.PasswordSignInAsync(model.Email,model.Password,true,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Employees","Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password is Incorrect.");
                    return View(model);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> showall()
        {
            return NoContent();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
