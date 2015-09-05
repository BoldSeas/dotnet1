using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmailDemo.Models
{
    public class EmailContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        public DbSet<UserInfo> UserInfos { get; set; }
    }
}