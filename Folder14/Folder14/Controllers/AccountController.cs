using Folder14.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Folder14.Controllers
{
    public class AccountController: Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            _signInManager=signInManager;
            _userManager = userManager;


          }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
