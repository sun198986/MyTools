using GraphQL.Types;
using LearnGraph.Api.Movies.Services;

namespace LearnGraph.Api.Movies.Schema
{
    public class MoviesQuery: ObjectGraphType
    {

        public MoviesQuery(IMovieService movieService)
        {

            Name = "Query";

            Field<ListGraphType<MovieType>>(
                "movies",
                resolve: context => movieService.GetAsync()
            );
        }
    }
}