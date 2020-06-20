using GraphQL.Types;
using LearnGraph.Api.Movies.Models;

namespace LearnGraph.Api.Movies.Schema
{
    public class ActorType:ObjectGraphType<Actor>
    {
        public ActorType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}