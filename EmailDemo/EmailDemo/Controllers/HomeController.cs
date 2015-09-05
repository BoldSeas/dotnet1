using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EmailDemo.Models;

namespace EmailDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<UserInfo> userList = new List<UserInfo>();
            using (EmailContext context = new EmailContext())
            {
                userList = context.UserInfos.ToList();
                //context.UserInfos.Add(new UserInfo()
                //{
                //    Email = "bjlianyu@hotmail.com",
                //    UserName = "lianyu"
                //});
                //context.SaveChanges();
            }

            return View(userList);
        }

    }
}
