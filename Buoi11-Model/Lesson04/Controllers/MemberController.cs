using Lesson04.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            var member = new Member();
            member.MemberId = Guid.NewGuid().ToString();
            member.UserName = "Vuongdactu";
            member.FullName = "Vương Đắc Tú";
            member.Password = "123456";
            member.Email = "dactu3@gmail.com";
            ViewBag.member = member;
            return View();
        }
        public IActionResult GetListMember() 
        {
            var members = new List<Member>()
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
            ViewBag.members = members;
            return View();
        }
        public IActionResult IndexModel()
        {
            var member = new Member();
            member.MemberId = Guid.NewGuid().ToString();
            member.UserName = "Vuongdactu";
            member.FullName = "Vương Đắc Tú";
            member.Password = "123456";
            member.Email = "dactu3@gmail.com";
            return View(member);
        }
        public IActionResult ListModel()
        {
            var members = new List<Member>()
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
            return View(members.ToList());
        }
        public IActionResult Create() 
        {
            var model = new Member();
            return View(model);
        }
    }
}
