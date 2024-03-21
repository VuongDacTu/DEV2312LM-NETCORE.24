using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLBook.Models;

namespace QLBook.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        //private BookStoreContext dbCategory = new BookStoreContext();
        private readonly BookStoreContext _context;

        public CategoryViewComponent(BookStoreContext context)
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
