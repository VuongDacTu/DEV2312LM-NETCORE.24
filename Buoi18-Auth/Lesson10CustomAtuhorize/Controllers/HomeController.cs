using Lesson10CustomAtuhorize.Models;
using Lesson10CustomAtuhorize.Models.DF;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Lesson10CustomAtuhorize.Controllers
{
    public class HomeController : Controller
    {
        private readonly DevXuongMocContext _context;
        public HomeController(DevXuongMocContext context)
        {
            _context = context;
        }


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
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }
            var pass = GetSHA26Hash(model.Password);
            var data = _context.Customers.Where(u => u.Username.Equals(model.Email)).FirstOrDefault(u => u.Password.Equals(pass));
            if(data == null)
            {
                ModelState.AddModelError(string.Empty, "Tài khoản không hợp lệ");
                return View(model);
            }
            //xử lý luêu trữ vào cookie
            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Email) }, "DevSecuritySchema");
            var priciple = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync("DevSecuritySchema", priciple);
            return RedirectToAction("Index","Admin");
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("DevSecuritySchema");
            return RedirectToAction("Index");
        }
        static string GetSHA26Hash(string input)
        {
            string hash = "";
            using (var sha256 = new SHA256Managed())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
            return hash;
        }
    }
}
