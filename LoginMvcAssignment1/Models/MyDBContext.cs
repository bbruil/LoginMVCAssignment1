using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace LoginMvcAssignment1.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("VisitorLog") { }

        public DbSet<Visitor> Visitors { get; set; }
    }
}