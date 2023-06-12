using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Student
{
    public class _StudentLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
