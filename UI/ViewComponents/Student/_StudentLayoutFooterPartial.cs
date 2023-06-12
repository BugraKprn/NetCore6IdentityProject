using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Student
{
    public class _StudentLayoutFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
