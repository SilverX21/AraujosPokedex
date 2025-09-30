using AraujosPokedex.Domain.Contracts;
using AraujosPokedex.Domain.Services.Pokemon;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AraujosPokedex.Api.Endpoints.Pokemon;

public static class AddPokemonEndpoint
{
    public const string Name = "AddPokemonEnpoint";

    public static IEndpointRouteBuilder MapAddPokemonEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("pokemon", async (
            [FromBody] AddPokemonRequest request,
            IValidator<AddPokemonRequest> pokemonValidator,
            IPokemonService pokemonService,
            CancellationToken cancellation
            ) =>
        {
            var validationResult = await pokemonValidator.ValidateAsync(request, cancellation);

            if (!validationResult.IsValid)
            {
                return Results.BadRequest(validationResult.Errors);
            }

            var validPokemon = await pokemonService.GetPokemonAsync(request.Name, cancellation);

            if (validPokemon is null)
            {
                return Results.NotFound(new { Message = "There isn't a Pokémon with that name. Please verify the pokémon name or supply it's Pokedex ID" });
            }

            var mappedPokemon = request;

            return Results.Created();
        })
            .WithName(Name)
            .Produces(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

        return app;
    }
}