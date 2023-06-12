using DtoLayer.Dtos.Student;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class StudentLayoutController : Controller
    {
        private readonly UserManager<Student> _userManager;

        public StudentLayoutController(UserManager<Student> userManager)
        {
            _userManager = userManager;
        }

        public async Task<PartialViewResult> PartialSidebar()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            StudentEditDto studentEditDto = new StudentEditDto();
            studentEditDto.Name = values.Name;
            studentEditDto.Surname = values.SurName;
            studentEditDto.ImageUrl = values.ImageUrl;
            return PartialView(studentEditDto);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
