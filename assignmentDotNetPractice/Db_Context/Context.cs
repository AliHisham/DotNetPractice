using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using assignmentDotNetPractice.Entites;


namespace assignmentDotNetPractice.Db_Context
{
    public class Context:DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
