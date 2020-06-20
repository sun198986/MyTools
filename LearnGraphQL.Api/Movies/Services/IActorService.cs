using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LearnGraph.Api.Movies.Models;

namespace LearnGraph.Api.Movies.Services
{
    public interface IActorService 
    {
        Task<Actor> GetByIdAsync(int id);
        Task<IEnumerable<Actor>> GetAsync();
    }
}