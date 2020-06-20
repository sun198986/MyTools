using GraphQL;

namespace LearnGraph.Api.Movies.Schema
{
    public class MovieSchema:GraphQL.Types.Schema
    {
        public MovieSchema(IDependencyResolver dependencyResolver,MoviesQuery moviesQuery)
        {
            DependencyResolver = dependencyResolver;
            Query = moviesQuery;
        }
    }
}