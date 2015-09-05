using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            using (var emailDb = new EmailContext())
            {
               

                emailDb.Emails.Add(new Email()
                {
                    ID = 1,
                    Title = "第一封邮件",
                    Content = "邮件内容",
                });
            }

            return View();
        }

    }
}
