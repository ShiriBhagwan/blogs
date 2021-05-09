using Microsoft.EntityFrameworkCore;
using System;

namespace PostAndBlogging.Api.Models
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Blogs> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>().HasData(new Blogs
            {
                ID = 1,
                Title = "Travelling",
                Content = "Why should go North India",
                Email = "sachinjain9891@gmail.com",
                CreationDate = new DateTime(1979, 04, 25),
                Updatedate = new DateTime(1979, 04, 25)

            }, new Blogs
            {
                ID = 2,
                Title = "Foodie",
                Content = "popular India Street food",
                Email = "sachinjain9891@gmail.com",
                CreationDate = new DateTime(1979, 04, 25),
                Updatedate = new DateTime(1979, 04, 25)
            });
        }
    }
}
