using Lesson08_Sessison.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Drawing.Printing;

namespace Lesson08_Sessison.Controllers
{

    public class LoginController : Controller
    {
        private readonly Lesson09DbContext _context;

        public LoginController(Lesson09DbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var jsonCustomer = HttpContext.Session.GetString("CustomerLogin");
            // lấy dữ liệu từ session -> chuyển lên giao diện và hiển thị
            if (jsonCustomer != null)
            {
                // chuyển dữ liệu từ Session ở dạng Json sang đối tượng Customer
                var CustomerModel = Newtonsoft.Json.JsonConvert.DeserializeObject<Customer>(jsonCustomer);
                return View(CustomerModel);
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            var modelLogin = new ModelLogin();
            return View(modelLogin);
        }

        [HttpPost]
        public IActionResult Login(ModelLogin modelLogin)
        {
            // kiểm tra tk mk >< DB
            //Nếu có lưu thông tin vào session
            var dataLogin = _context.Customers.FirstOrDefault(x => x.Username.Equals(modelLogin.UserName) && x.Password.Equals(modelLogin.PassWord));
            if(dataLogin != null)
            {
                ViewBag.Login = "Đăng nhập thành công";
                var customerLogin = Newtonsoft.Json.JsonConvert.SerializeObject(dataLogin);
                HttpContext.Session.SetString("CustomerLogin", customerLogin);
                return RedirectToAction("Index");
            }
            return View(modelLogin);
        }

        //Đăng xuất
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("CustomerLogin");
            return RedirectToAction("Login");
        }
    }
}
