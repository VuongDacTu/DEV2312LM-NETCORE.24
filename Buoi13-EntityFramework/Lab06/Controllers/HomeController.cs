using Lab06.Models;
using Lab06.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lab06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //public HomeController(AppDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //// GET: Products
        //private readonly AppDbContext _context;
        //public async Task<IActionResult> Product(AppDbContext context)
        //{
        //    var appDbContext = _context.Products.Include(p => p.Category);
        //    return View(await appDbContext.ToListAsync());
        //}
    }
}
