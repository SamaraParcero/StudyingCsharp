using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Data;

namespace RazorPagesMovies.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMoviesContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Senhor dos anéis",
                        ReleaseDate = DateTime.Parse("1999-1-10"),
                        Genre = "Fantasia",
                        Price = 50.99M
                    },
                    new Movie
                    {
                        Title = "O hobbit",
                        ReleaseDate = DateTime.Parse("1998-1-10"),
                        Genre = "Fantasia",
                        Price = 30
                    }, 
                    new Movie
                    {
                        Title = "As branquelas",
                        ReleaseDate = DateTime.Parse("2000-1-10"),
                        Genre = "Comédia",
                        Price = 33.99M
                    },
                    new Movie
                    {
                        Title = "1989",
                        ReleaseDate = DateTime.Parse("1989-1-10"),
                        Genre = "Ficção científica",
                        Price = 20.80M
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
