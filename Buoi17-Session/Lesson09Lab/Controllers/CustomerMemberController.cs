using Lesson09Lab.Models;
using Lesson09Lab.Models.CustomerModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Security.Cryptography;
using System.Text;

namespace Lesson09Lab.Controllers
{
    public class CustomerMemberController : Controller
    {
        private readonly DevXuongMocContext _context;
        public CustomerMemberController(DevXuongMocContext context)
        {
            _context = context;
        }
        public IActionResult LoginCustomer(string url)
        {
            if (HttpContext.Session.GetString("Member") != null)
            {
                var dataLogin = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                ViewBag.customer = dataLogin;
            }
            ViewBag.UrlAction = url;
            return View();
        }

        [HttpPost]
        public IActionResult Registy(Customer model) 
        {
            try
            {
                var pass = GetSHA26Hash(model.Password);
                model.Password = pass;
                model.CreatedDate = DateTime.Now;
                model.UpdateDate = DateTime.Now;
                model.Isactive = 1;
                _context.Add(model);
                _context.SaveChanges();
                return View();
            }
            catch (Exception ex)
            {
                TempData["errorRegistry"] = "Lỗi đăng ký " + ex.Message;
                return RedirectToAction("LoginCustomer");
            }
        }
        [HttpPost]
        public IActionResult Login(Login model, string urlAction)
        {
            var pass = GetSHA26Hash(model.password);
            var data = _context.Customers.Where(x => x.Isactive == 1).Where(x => x.Username.Equals(model.UserOrEmail) || x.Email.Equals(model.UserOrEmail)).FirstOrDefault(x => x.Password.Equals(pass));
            var dataLogin = data.ToJson();
            if(data != null)
            {
                HttpContext.Session.SetString("Member", dataLogin);
                if (!string.IsNullOrEmpty(urlAction))
                {
                    return Redirect(urlAction);
                }
                return RedirectToAction("LoginCustomer");
            }
            TempData["errorLogin"] = "Lỗi đăng nhập";
            return RedirectToAction("LoginCustomer");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Member");
            return RedirectToAction("LoginCustomer");
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
