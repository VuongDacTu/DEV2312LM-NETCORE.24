using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lesson09Lab.Areas.Admins.Controllers
{
    public class BaseController : Controller, IActionFilter
    {
        [Area("Admins")]

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.HttpContext.Session.GetString("AdminLogin") == null)
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { Controller = "Login", Action = "Index", Areas = "Admins" }));
            }
            base.OnActionExecuted(context);
        }


    }
}
