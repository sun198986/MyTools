using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnGraph.Api.Movies.Models;

namespace LearnGraph.Api.Movies.Services
{
    public class ActorService:IActorService
    {

        private readonly IList<Actor> _actors;

        public ActorService()
        {
            _actors = new List<Actor>
            {
                new Actor{Id=1,Name = "Tom1"},
                new Actor{Id=2,Name = "Tom2"},
                new Actor{Id=3,Name = "Tom3"},
                new Actor{Id=4,Name = "Tom4"},
                new Actor{Id=5,Name = "Tom5"}
            };
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            return Task.FromResult(_actors.SingleOrDefault(x => x.Id == id));
        }

        public Task<IEnumerable<Actor>> GetAsync()
        {
            return Task.FromResult(_actors.AsEnumerable());
        }
    }
}