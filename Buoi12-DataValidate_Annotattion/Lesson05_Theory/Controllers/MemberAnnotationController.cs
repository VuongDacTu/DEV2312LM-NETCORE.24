using Lesson05_Theory.Models.DataModels;
using Lesson05_Theory.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05_Theory.Controllers
{
    public class MemberAnnotationController : Controller
    {
        public static readonly List<RegisterViewModel> members = new List<RegisterViewModel>();
        // GET: MemberAnnotationController
        public ActionResult Index()
        {
            return View(members);
        }

        // GET: MemberAnnotationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberAnnotationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberAnnotationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            else
                return RedirectToAction(nameof(Index));
 
        }

        // GET: MemberAnnotationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberAnnotationController/Edit/5
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

        // GET: MemberAnnotationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberAnnotationController/Delete/5
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
