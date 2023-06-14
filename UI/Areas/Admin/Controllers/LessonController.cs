using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LessonController : Controller
    {
        LessonManager lessonManager = new LessonManager(new EfLessonDal());
        public IActionResult Index()
        {
            var values = lessonManager.TGetAll();
            return View(values);
        }
    }
}
