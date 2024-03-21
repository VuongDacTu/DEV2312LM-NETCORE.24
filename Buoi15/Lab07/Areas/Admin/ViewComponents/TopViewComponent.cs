using Microsoft.AspNetCore.Mvc;

namespace Lab07.Areas.Admin.ViewComponents
{
    public class TopViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() { 
            return View();
        }
    }
}
