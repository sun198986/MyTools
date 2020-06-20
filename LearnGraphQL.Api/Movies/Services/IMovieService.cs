using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using LearnGraph.Api.Movies.Models;

namespace LearnGraph.Api.Movies.Services
{
    public interface IMovieService
    {
        Task<Movie> GetByIdAsync(int id);
        Task<IEnumerable<Movie>> GetAsync();
        Task<Movie> CreateAsync(Movie movie);

    }
}