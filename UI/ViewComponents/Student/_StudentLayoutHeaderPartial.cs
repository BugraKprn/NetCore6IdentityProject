using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Student
{
    public class _StudentLayoutHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
