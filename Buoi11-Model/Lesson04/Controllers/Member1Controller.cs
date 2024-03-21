using Lesson04.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04.Controllers
{
    public class Member1Controller : Controller
    {
        private static List<Member> list = new List<Member>() 
        {
                new Member {
                MemberId = Guid.NewGuid().ToString(),
                FullName = "Member 1", UserName = "mem1",
                Password = "123",
                Email = "member1@gmail.com"
                },
                new Member {
                MemberId = Guid.NewGuid().ToString(),
                FullName = "Member 2", UserName = "mem2",
                Password = "123",
                Email = "member2@gmail.com"
                },
                new Member {
                MemberId = Guid.NewGuid().ToString(),
                FullName = "Member 3", UserName = "mem3",
                Password = "123",
                Email = "member3@gmail.com"
                },
                new Member {
                MemberId = Guid.NewGuid().ToString(),
                FullName = "Member 4", UserName = "mem4",
                Password = "123",
                Email = "member4@gmail.com"
                },
                new Member {
                MemberId = Guid.NewGuid().ToString(),
                FullName = "Member 5", UserName = "mem5",
                Password = "123",
                Email = "member5@gmail.com"
                },
        };
        // GET: Member1Controller
        public ActionResult Index()
        {
            return View(list);
        }

        // GET: Member1Controller/Details/5
        public ActionResult Details(string id)
        {
            var model = list.FirstOrDefault(m => m.MemberId == id);
            return View(model);
        }

        // GET: Member1Controller/Create
        public ActionResult Create()
        {
            var member = new Member();
            return View(member);
        }

        // POST: Member1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                member.MemberId = Guid.NewGuid().ToString();
                list.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Member1Controller/Edit/5
        public ActionResult Edit(string id)
        {
            var model = list.FirstOrDefault(m => m.MemberId == id);
            return View(model);
        }

        // POST: Member1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Member member)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].MemberId == id)
                    {
                        list[i] = member;
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

        // GET: Member1Controller/Delete/5
        public ActionResult Delete(string id)
        {
            var model = list.FirstOrDefault(m => m.MemberId == id);

            return View(model);
        }

        // POST: Member1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Member member)
        {
            try
            {
                for(int i = 0;i < list.Count; i++)
                {
                    if (list[i].MemberId == id) list.RemoveAt(i);
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
