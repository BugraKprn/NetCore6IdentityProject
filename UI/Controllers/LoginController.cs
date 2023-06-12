using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<Student> _signInManager;
        private readonly UserManager<Student> _userManager;

        public LoginController(
            SignInManager<Student> signInManager,
            UserManager<Student> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, false, true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.Username);
                if (user.EmailConfirmed == true)
                {
                    return RedirectToAction("Index", "Profile");
                }
                // else Lütfen mail adresinizi onaylayın !
            }
            // Kullanıcı adı veya şifre hatalı
            return View();
        }
    }
}
