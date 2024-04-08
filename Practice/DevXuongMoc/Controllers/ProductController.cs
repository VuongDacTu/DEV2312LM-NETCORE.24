using DevXuongMoc.Models.DevXuongMocModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Controllers
{
	
	public class ProductController : Controller
	{
        private readonly DevXuongMocContext _context;
        public ProductController(DevXuongMocContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
		{
			return View(await _context.Products.ToListAsync());
		}
	}
}
