using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "Iron Man",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Iron Man 2",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Avengers",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Avengers 2",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "SciFi",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Harry Potter",
                    ReleaseDate = DateTime.Parse("2024-1-2"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 5.70M
                }
            );
            context.SaveChanges();
        }
    }
}