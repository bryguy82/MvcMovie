using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Legacy",
                        ReleaseDate = DateTime.Parse("1993-3-7"),
                        Genre = "Drama",
                        Price = 11.75M,
                        Rating = "G",
                        ImagePath = "legacy.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 6.68M,
                        Rating = "PG",
                        ImagePath = "meet_the_mormons.jpg"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-9"),
                        Genre = "Action",
                        Price = 26.94M,
                        Rating = "PG-13",
                        ImagePath = "the_saratov_approach.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Adventure",
                        Price = 11.99M,
                        Rating = "PG",
                        ImagePath = "the_other_side_of_heaven.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven 2: Fire of Faith",
                        ReleaseDate = DateTime.Parse("2019-6-30"),
                        Genre = "Adventure",
                        Price = 11.99M,
                        Rating = "PG-13",
                        ImagePath = "the_other_side_of_heaven_2.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "History",
                        Price = 12.30M,
                        Rating = "PG",
                        ImagePath = "17_miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy",
                        Price = 32.73M,
                        Rating = "PG",
                        ImagePath = "the_best_two_years.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-1-30"),
                        Genre = "Comedy",
                        Price = 19.75M,
                        Rating = "PG",
                        ImagePath = "the_singles_ward.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}