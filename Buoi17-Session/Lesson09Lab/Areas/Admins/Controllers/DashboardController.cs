using Microsoft.AspNetCore.Mvc;

namespace Lesson09Lab.Areas.Admins.Controllers
{
    [Area("Admins")]

    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
