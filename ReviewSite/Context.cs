using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class Context : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Concert" },
                new Category() { Id = 2, Name = "Book" },
                new Category() { Id = 3, Name = "Food"},
                new Category() { Id = 4, Name = "Album"}
                );
           
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, CategoryId = 1, Title = "Hard Rain at Natalies Coal Fired Pizza", ImageUrl = "./www.root/images/NemoMuseum.jpg", Content = "Hard Rain rocked the house to a sold out crowd Friday 10-19-18" },
                new Review() { Id = 2, CategoryId = 2, Title = "Hunt for Red Oktober", ImageUrl = "./www.root/images/bookcover.jpg", Content = "The classic by Tom Clancy that inpired the movie of the same name!" },
                new Review() { Id = 3, CategoryId = 2, Title = "Of Mice and Men", ImageUrl = "./www.root/images/bookcover.jpg", Content = "the timeless John Steinbeck classic" },
                new Review() { Id = 4, CategoryId = 4, Title = "Deep In The Shadows", ImageUrl = "./www.root/images/album.jpg", Content = "Blue Eyed Soul, Rythem and Blues from \"The PGH Rockers\" " },
                new Review() { Id = 5, CategoryId = 3, Title = " Double Philly Cheese Steak Deluxe from Mr. Hero", ImageUrl = "./www.root/images/piggyLunch.jpg", Content = "If grease brings you gastronomic peace, then this dish should be your wish!"}
                );
            base.OnModelCreating(modelBuilder);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=KHReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }


    }
}
