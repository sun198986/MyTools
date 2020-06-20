using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnGraph.Api.Movies.Models;

namespace LearnGraph.Api.Movies.Services
{
    public class MovieService:IMovieService
    {

        private readonly IList<Movie> _movies;

        public MovieService()
        {
            #region Movies
            _movies = new List<Movie>
            {
                new Movie
                {
                    Id=1,
                    Name = "Forrest Gump",
                    ActorId = 1,
                    Company = "Paramount Pictures",
                    MovieRating = MovieRating.PG13,
                    ReleaseDate = new DateTime(1997,7,6)
                },
                new Movie
                {
                    Id=2,
                    Name = "Se7en",
                    ActorId = 2,
                    Company = "New Line Cinema",
                    MovieRating = MovieRating.R,
                    ReleaseDate = new DateTime(1995,7,11)
                },
                new Movie
                {
                    Id=3,
                    Name = "Top Gun",
                    ActorId = 3,
                    Company = "Paramount Pictures",
                    MovieRating = MovieRating.PG,
                    ReleaseDate = new DateTime(1997,5,12)
                },
                new Movie
                {
                    Id=4,
                    Name = "Keep",
                    ActorId = 4,
                    Company = "Endiglt",
                    MovieRating = MovieRating.PG13,
                    ReleaseDate = new DateTime(2000,12,6)
                },
                new Movie
                {
                    Id=5,
                    Name = "The Notebook",
                    ActorId = 5,
                    Company = "New Line Cinema",
                    MovieRating = MovieRating.PG13,
                    ReleaseDate = new DateTime(2004,1,1)
                },
            };
            #endregion
        }
        public Task<Movie> GetByIdAsync(int id)
        {
            return Task.FromResult(_movies.SingleOrDefault(x => x.Id == id));
        }

        public Task<IEnumerable<Movie>> GetAsync()
        {
            return Task.FromResult(_movies.AsEnumerable());
        }

        public Task<Movie> CreateAsync(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}