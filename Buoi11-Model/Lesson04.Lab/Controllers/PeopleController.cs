using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lesson04.Lab.Models;
using System.Linq;
using System.IO;
namespace Lesson04.Lab.Controllers
{
    public class PeopleController : Controller
    {
        // GET: PeopleController
        public ActionResult Index()
        {
            var _peoples = DataLocal.GetPeoples();
            return View(_peoples);
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            People people = new People();
            return View(people);
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People model)
        {
            try
            {
                
                // up load file vào thư mục wwwroot/images/avartar
                var files = HttpContext.Request.Form.Files;
                //using System.Linq
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", FileName);
                    //using System.IO
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "images/avatar/" + FileName;
                    }
                }
                //thêm people vào danh sách Datalocal
                DataLocal._people.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(model);
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
        {
            try
            {
                // up load file vào thư mục wwwroot/images/avartar
                var files = HttpContext.Request.Form.Files;
                //using System.Linq
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", FileName);
                    //using System.IO
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "images/avatar/" + FileName;
                    }
                }
                // cập nhật model vào danh sách DataLocal
                for (int i = 0;i<DataLocal._people.Count;i++)
                {
                    if (DataLocal._people[i].Id == id)
                    {
                        DataLocal._people[i] = model;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, People model)
        {
            try
            {
                for (int i = 0; i < DataLocal._people.Count(); i++)
                {
                    if (DataLocal._people[i].Id == id)
                    {
                        DataLocal._people.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
