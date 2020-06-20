using GraphQL.Types;
using LearnGraph.Api.Movies.Models;
using LearnGraph.Api.Movies.Services;

namespace LearnGraph.Api.Movies.Schema
{
    public class MovieType:ObjectGraphType<Movie>
    {
        public MovieType(IActorService actorService)
        {
            Name = "Movie";
            Description = "";

            Field(x => x.Id);
            Field(x => x.Company);
            Field(x => x.Name);
            Field(x => x.ReleaseDate);
            Field(x => x.ActorId);

            Field<MovieRatingEnum>("movieRatings", resolve: context => context.Source.MovieRating);
            Field<ActorType>("actor", resolve: context => actorService.GetByIdAsync(context.Source.ActorId));

            Field<StringGraphType>("customString", resolve: context => "1234");
        }
    }
}