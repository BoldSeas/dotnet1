using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmailDemo.Models
{
    public class EmailInitializer : DropCreateDatabaseIfModelChanges<EmailContext>
    {
        protected override void Seed(EmailContext context)
        {
            var emai1 = new List<UserInfo>
            {
                new UserInfo()
                {
                    ID = 1,UserName = "lianyu",Email = "yu.lian@boldseas.com"
                },
                 new UserInfo()
                {
                    ID = 2,UserName = "Zhang Tieli",Email = "tieli.zhang@boldseas.com"
                }
            };
           Database.SetInitializer<EmailContext>(new EmailInitializer());
        }

    }
}