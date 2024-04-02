using Lesson09Lab.Models;
using Lesson09Lab.Models.CustomerModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Numerics;

namespace Lesson09Lab.Controllers
{
    public class CartController : Controller
    {
        private readonly DevXuongMocContext _context;
        private static List<Cart> carts = new List<Cart> { };
        public CartController(DevXuongMocContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuted(context);
        }
        public IActionResult Index()
        {
            //var cartInSession = HttpContext.Session.GetString("My-Cart");
            //if (cartInSession != null)
            //{
                //var ct = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
                float total = 0;
                foreach (var item in carts)
                {
                    total += item.Quantity * item.Price;
                }
                ViewBag.total = total;
                return View(carts);
            //}

            return RedirectToAction("Index", "Products");
        }
        public IActionResult Add(int id)
        {
            if(carts.Any(c => c.Id == id)) // nếu sản phẩm này đã có trong giỏ hàng
            {
                carts.Where(c => c.Id == id).First().Quantity += 1; // tăng số lượng
            }
            else // nếu sản phẩm chưa có trong giỏ hàng, thêm sản phẩm vào giỏ
            {
                var p = _context.Products.Find(id); // tìm sản phẩm cần mua trong bảng sản phẩm
                //tạo mới một sản phẩm để thêm vào giỏ hàng
                var item = new Cart()
                {
                    Id = p.Id,
                    Name = p.Title,
                    Price = (float)p.PriceNew.Value,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)(p.PriceNew.Value * 1),
                };
                carts.Add(item);
            }
            // lưu carts vào session, cần phải chuyển sang dữ liệu Json
            HttpContext.Session.SetString("My-Cart",JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            if(carts.Any(c => c.Id == id))
            {
                var item = carts.Where(c => c.Id == id).First();
                carts.Remove(item);
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));

            }
            return RedirectToAction("Index");

        }
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction("Index");
        }
    }
}
