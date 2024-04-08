using Lesson09Lab.Models;
using Lesson09Lab.Models.CustomerModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            //return RedirectToAction("Index", "Products");
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
        public IActionResult Orders()
        {
            if(HttpContext.Session.GetString("Member") == null)
            {
                return RedirectToAction("LoginCustomer", "CustomerMember");
            }
            else
            {
                var dataMember = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                ViewBag.customer = dataMember;
                float total = 0;
                foreach(var item in carts)
                {
                    total += item.Quantity * item.Price;
                }
                ViewBag.total = total;
                // Phương thức thanh toán
                var dataPay = _context.PaymentMethods.ToList();
                ViewData["IdPayment"] = new SelectList(dataPay, "Id", "Name", 1);
            }
            return View(carts);
        }
        public IActionResult Update(int id, int quantity)
        {
            if(carts.Any(c => c.Id == id))
            {
                carts.Where(c => c.Id == id).First().Quantity = quantity;
                HttpContext.Session.SetString("My-Cart",JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> OrderPay(IFormCollection form)
        {
            try
            {
                // thêm bảng order
                var order = new Order();
                order.NameReciver = form["NameReciver"];
                order.Email = form["Email"];
                order.Phone = form["Phone"];
                order.Address = form["Address"];
                order.Notes = form["Notes"];
                order.Idpayment = long.Parse(form["Idpayment"]);
                order.OrdersDate = DateTime.Now;
                var dataMember = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                order.Idcustomer = dataMember.Id;
                decimal total = 0;
                foreach (var item in carts)
                {
                    total += item.Quantity + (decimal)item.Price;
                }
                order.TotalMoney = total;
                // tạo orderId
                var strOrderId = "DH";
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd.HH-mm-ss.fff");
                strOrderId += "." + timestamp;
                order.Idorders = strOrderId;
                _context.Add(order);
                await _context.SaveChangesAsync();
                // lấy id bảng orders
                var dataOder = _context.Orders.OrderByDescending(x => x.Id).FirstOrDefault();
                foreach(var item in carts)
                {
                    OrderDetail od = new OrderDetail();

                    od.Id = _context.OrderDetails.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
                    od.Idord = dataOder.Id;
                    od.Idproduct = item.Id;
                    od.Qty = item.Quantity;
                    od.Price = (decimal)item.Price;
                    od.Total = (decimal) item.Total;
                    od.ReturnQty = 0;
                    _context.Add(od);
                    await _context.SaveChangesAsync();
                }
                HttpContext.Session.Remove("My-Cart");
            }
            catch (Exception ex)
            {
                throw;

            }
            return View();


        }
    }
}
