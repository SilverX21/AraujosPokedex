namespace AraujosPokedex.Domain.Services.Pokemon;

public interface IPokemonService
{
    Task<object?> GetPokemonAsync(string idOrName, CancellationToken cancellationToken = default);

    Task<List<Models.Pokemon>> GetPokemonListAsync();
}