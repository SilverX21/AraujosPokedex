using AraujosPokedex.Domain.Services.Pokemon;

namespace AraujosPokedex.Api.Endpoints.Pokemon;

public static class GetPokemonEndpoint
{
    public const string Name = "GetPokemonEndpoint";

    public static IEndpointRouteBuilder MapGetPokemonEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("pokemon", async (
            string idOrName,
            IPokemonService pokemonService,
            CancellationToken cancellationToken
            ) =>
        {
            if (string.IsNullOrEmpty(idOrName))
                return Results.BadRequest(new { Message = "Please insert a pokemon name or it's corresponding pokedex entry." });

            var response = await pokemonService.GetPokemonAsync(idOrName, cancellationToken);

            if (response is null)
                return Results.BadRequest(new { Message = "No Pokemon was found with the requested name or pokedex entry Id" });

            return Results.Ok(response);
        })
            .WithName(Name)
            .WithSummary("Get's a given pokemon details by it's name or pokedex entry Id")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

        return app;
    }
}