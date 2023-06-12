using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DtoLayer.Dtos.Student;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace UI.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<Student> _userManager;

        public ProfileController(UserManager<Student> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Id;
            StudentEditDto studentEditDto = new StudentEditDto();
            studentEditDto.StudentNumber = values.StudentNumber;
            studentEditDto.Address = values.Adresss;
            studentEditDto.Gender = values.Gender;
            studentEditDto.Name = values.Name;
            studentEditDto.Surname = values.SurName;
            studentEditDto.Email = values.Email;
            studentEditDto.PhoneNumber = values.PhoneNumber;
            studentEditDto.ImageUrl = values.ImageUrl;
            return View(studentEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(StudentEditDto studentEditDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Adresss = studentEditDto.Address;
            user.Email = studentEditDto.Email;
            user.PhoneNumber = studentEditDto.PhoneNumber;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
    }
}
