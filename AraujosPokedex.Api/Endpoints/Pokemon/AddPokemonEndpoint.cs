using AraujosPokedex.Domain.Contracts;

namespace AraujosPokedex.Api.Endpoints.Pokemon;

public static class AddPokemonEndpoint
{
    public static IEndpointRouteBuilder MapAddPokemonEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("pokemon", async (
            AddPokemonRequest request,
            CancellationToken cancellation
            ) =>
        {
            return Results.Ok();
        });

        return app;
    }
}