using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace CoreDemo.EFCore
{
     public class Context:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Server=localhost;Database=CoreBlogDb;Port=5432;User Id=postgres;Password=3PFZKS;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }


    }
}
