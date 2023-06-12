using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Student
{
    public class _StudentLayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
