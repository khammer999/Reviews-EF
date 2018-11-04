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
                new Category() { Id = 1, Name = "Concerts"},
                new Category() { Id = 2, Name = "Books"},
                new Category() { Id = 3, Name = "Dining" },
                new Category() { Id = 4, Name = "Album"}
                );
           
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, CategoryId = 1, Title = "Hard Rain at MusicBox Supper Club", ImageUrl = "/images/band.jpg", Content = "Hard Rain rocked the house to a sold out crowd Friday August 10th, 2018 " },
                new Review() { Id = 2, CategoryId = 2, Title = "Hunt for Red Oktober", ImageUrl = "/images/redOctober.jpg", Content = "The classic by Tom Clancy that inpired the movie of the same name!" },
                new Review() { Id = 3, CategoryId = 2, Title = "Of Mice and Men", ImageUrl = "/images/ofMiceAndMen.jpg", Content = "the timeless John Steinbeck classic" },
                new Review() { Id = 4, CategoryId = 4, Title = "Deep In The Shadows", ImageUrl = "/images/deepInTheShadows.jpg", Content = "Blue Eyed Soul, Rhythym and Blues from \"The PGH Rockers\" featuring the hits \"Darkest Side of Town\" and \"The Man Who Won The War\"" },
                new Review() { Id = 5, CategoryId = 3, Title = "Primanti Bothers", ImageUrl = "/images/primantiBros.jpg", Content = "Jeet jet? Jah wanna sammich N'at? then yinz better get dahntahn for this-un. I cut the sammiches half in two for yinz cuz Mills on Wills don't never bring halupki, haluski, or kolachis. It's a 'Burgh Thing!" }
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
