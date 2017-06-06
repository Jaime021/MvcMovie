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
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    Director = "Bob The Director",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 7.99M
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     Director = "Bob The Director",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     Director = "Bob brother The Director",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "R",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   Director = "Michael Bay",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "G",
                   Price = 3.99M
               }
           );

        }
    }
}
