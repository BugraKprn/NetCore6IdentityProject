using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassroomController : Controller
    {
        ClassroomManager classroomManager = new ClassroomManager(new EfClassroomDal());
        public IActionResult Index()
        {
            var values = classroomManager.TGetAll();
            return View(values);
        }
    }
}
