using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailDemo.Models
{
    public class Email
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int FromUserID { get; set; }

        public int ToUserID { get; set; }
    }
}