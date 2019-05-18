using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace stu201831980117.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<stu201831980117.Models.students> Students { get; set; }

    }
}