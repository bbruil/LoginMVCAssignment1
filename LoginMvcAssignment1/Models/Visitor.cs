using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginMvcAssignment1.Models
{
    public class Visitor
    {
        [Key]
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public DateTime LoginTime { get; set; }
        public string IpAddress { get; set; }
    }
}