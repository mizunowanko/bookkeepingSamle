using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace 家計簿試作品.Models
{
    public class Context : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}