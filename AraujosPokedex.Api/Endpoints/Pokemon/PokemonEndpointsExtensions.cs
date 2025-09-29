namespace AraujosPokedex.Api.Endpoints.Pokemon;

public static class PokemonEndpointsExtensions
{
    public static IEndpointRouteBuilder MapPokemonEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapAddPokemonEndpoint();
        app.MapGetPokemonEndpoint();

        return app;
    }
}