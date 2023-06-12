using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Student
{
    public class _StudentLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
