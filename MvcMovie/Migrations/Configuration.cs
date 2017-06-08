namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MvcMovie.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    //Optional Area For the Stars to be inputed, right now just using 
                    // the score to have stars display on the screen 
                    Title = "When Harry Met Sally",
                    Director = "Bob The Director",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Score = 3M,
                    //Stars = "3",
                    Rating = "PG",
                    Price = 7.99M
                   
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     Director = "Bob The Director",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Score = 7.8M,
                     //Stars = "7.8",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     Director = "Bob brother The Director",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Score = 3.2M,
                     //Stars = "3.2",
                     Rating = "R",
                     Price = 9.99M
                 },
                 

               new Movie
               {
                     Title = "The Godfather",
                     Director = "Francis Ford Coppola",
                     ReleaseDate = DateTime.Parse("1972-3-24"),
                     Genre = "Drama",
                     Score = 9.2M,
                    // Stars = "9.2",
                     Rating = "R",
                     Price = 9.99M
               },

               new Movie
               {
                   Title = "Rio Bravo",
                   Director = "Michael Bay",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Score = 8,
                  // Stars = "8",
                   Rating = "G",
                   Price = 3.99M
               },
               new Movie
               {
                   Title = "The Bomb",
                   Director = "Michael Bay",
                   ReleaseDate = DateTime.Parse("2017-6-15"),
                   Genre = "Action",
                   Score = 8,
                  // Stars = "9.5",
                   Rating = "R",
                   Price = 3.99M
               }
           );

        }
    }
}
