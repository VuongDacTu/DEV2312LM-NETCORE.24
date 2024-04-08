using DevXuongMoc.Models.DevXuongMocModels;
using DevXuongMoc.Models.LoginModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace DevXuongMoc.Controllers
{
    public class LoginController : Controller
    {
        private readonly DevXuongMocContext _context;
        public LoginController(DevXuongMocContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Customer model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var pass = GetSHA26Hash(model.Password);
            var data = _context.Customers.Where(u => u.Username.Equals(model.Email) || u.Email.Equals(model.Email)).FirstOrDefault(u => u.Password.Equals(pass));
            if(data != null)
            {
				var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Email) }, "DevSecuritySchema");
				var priciple = new ClaimsPrincipal(identity);
				HttpContext.SignInAsync("DevSecuritySchema", priciple);
				return RedirectToAction("Index", "Product");
			}
			ModelState.AddModelError(string.Empty, "Tài khoản không hợp lệ");
            TempData["errorLogin"] = "Email or password is incorrect";
			return View();
		}
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("DevSecuritySchema");
			return RedirectToAction("Login");
		}
        [HttpPost] 
        public IActionResult Register(Customer model)
        {
            var cus = new Customer()
            {
                Name = model.Name,
                Email = model.Email,
                Username = model.Username,
                Password = GetSHA26Hash(model.Password),
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Isactive = 1
            };
            _context.Add(cus);
            _context.SaveChanges();
            return RedirectToAction("Login");
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
