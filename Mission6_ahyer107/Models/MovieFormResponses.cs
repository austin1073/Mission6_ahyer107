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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieFormResponse>().HasData(

                new MovieFormResponse
                {
                    MovieId = 1,
                    Category = "Action",
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
                    Category = "Action",
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
                    Category = "Comedy",
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
