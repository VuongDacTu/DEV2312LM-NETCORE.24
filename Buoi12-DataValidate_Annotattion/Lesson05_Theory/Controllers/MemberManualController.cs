using Lesson05_Theory.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.RegularExpressions;

namespace Lesson05_Theory.Controllers
{
    public class MemberManualController : Controller
    {
        public static readonly List<Member> members = new List<Member>();
        // GET: MemberController
        public ActionResult Index()
        {
            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member  member)
        {

            string msg = null;
            bool validate = true;
            if(member.UserName.Length < 3 || member.UserName.Length > 20 || member.UserName==null)
            {
                msg = "<li>Tên đăng nhập phải có độ dài từ 3-20 ký tự</li>";
                validate = false;
            }
            string paternemail = @"[a-z0-9._%+-] + @[a-z0-9.-]+\.[a-z]{2,4}$";
            if(!Regex.IsMatch(member.Email, paternemail) || member.Email == null)
            {
                msg += "<li>Email không đúng định dạng</li>";
                validate = false;
            }
            if(member.Birtday.AddYears(18) > DateTime.Now || member.Birtday == null)
            {
                msg += "<li>Bạn chưa đủ 18 tuổi</li>";
                validate=false;
            }
            string patternphone = @"^\d{9,12}$";
            if (!Regex.IsMatch(member.Phone, patternphone) || member.Phone == null)
            {
                msg = "<li>Số điện thoại không hợp lệ";
                validate = false;
            }

                if(validate)
                {
                    member.MemberId = Guid.NewGuid().ToString();
                    members.Add(member);
                     return RedirectToAction(nameof(Index));

                }
            else
            {
                ViewBag.msg = "<div class = 'alert alert-danger'>" + msg + "</div";
                return View(member);
            }

        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
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

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
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
    }
}
