using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10CustomAtuhorize.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
