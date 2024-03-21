using Lab07.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Areas.Admin.ViewComponents
{
    public class LeftViewComponent : ViewComponent
    {
        private readonly DbAdminAlteContext _context;
        public LeftViewComponent(DbAdminAlteContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = _context.Categories.ToList();
            return View(list);
        }
    }
}
