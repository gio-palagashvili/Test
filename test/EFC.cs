using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace test
{
    public class EfcTest
    {
        public class BloggingContext : DbContext
        {
            public DbSet<Show> Blogs { get; set; }
            public object Shows { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=imdb_db;Integrated Security=True");
            }
        }
        public class Show
        {
            public int ShowId { get; set; }
        }

        public EfcTest()
        {
            
            using var context = new BloggingContext();
            var blog = context.Blogs
                .Single(b => b.ShowId == 1);
            Console.WriteLine(blog);
        }
    }
}