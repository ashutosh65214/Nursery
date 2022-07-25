using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Nursery.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("NurceryConn")
        {

        }
        public DbSet<Nursery> nurseries { get; set; }
        public DbSet<Category> categories { get; set; }




    }
}