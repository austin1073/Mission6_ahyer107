using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ahyer107.Models
{
    //Seeding the database with three movies on creation
    public class MovieFormResponses : DbContext
    {
        public MovieFormResponses (DbContextOptions<MovieFormResponses> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieFormResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //This creates all the categories and links them to a category ID
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Action/Adventure"},
                    new Category { CategoryId = 2, CategoryName = "Comedy"},
                    new Category { CategoryId = 3, CategoryName = "Drama" },
                    new Category { CategoryId = 4, CategoryName = "Family" },
                    new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                    new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                    new Category { CategoryId = 7, CategoryName = "Television" },
                    new Category { CategoryId = 8, CategoryName = "VHS" }
                );


            mb.Entity<MovieFormResponse>().HasData(

                new MovieFormResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Jurrasic Park",
                    Year = 1993,
                    Director = "Steven Spielberg",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Parker",
                    Notes = "Best movie ever"
                },
                new MovieFormResponse
                {
                    MovieId = 2,
                    CategoryId = 1,
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Chester",
                    Notes = "Best Marvel Movie out there"
                },
                new MovieFormResponse
                {
                    MovieId = 3,
                    CategoryId = 2,
                    Title = "Hitch",
                    Year = 2005,
                    Director = "Andy Tennant",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Andrew",
                    Notes = "How to pick up chicks"
                }
            ); 
        }
    }
}
