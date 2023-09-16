using MVCSearchFunctionality.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCSearchFunctionality.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}