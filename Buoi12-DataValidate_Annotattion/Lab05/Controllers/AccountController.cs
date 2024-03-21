using Lab05.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lab05.Controllers
{
    public class AccountController : Controller
    {
        List<Account> accounts = new List<Account>();
        // GET: AccountController
        public ActionResult Index()
        {
            return View(accounts);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            Account account = new Account();
            return View(account);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [AcceptVerbs("GET","POST")]
        public IActionResult VerifyPhone(string phoneNumber)
        {


            Regex _isPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (phoneNumber == null)
            {
                return Json($"Số điện thoại {phoneNumber} không đúng định dạng, VD: 0937483947 hoặc 093.849.9183");
            }
            else
            if (!_isPhone.IsMatch(phoneNumber))
            {
                return Json($"Số điện thoại {phoneNumber} không đúng định dạng, VD: 0937483947 hoặc 093.849.9183");
            }else
            return Json(true);
        }
    }
}
