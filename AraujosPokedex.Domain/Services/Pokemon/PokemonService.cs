using System.Net.Http.Json;

namespace AraujosPokedex.Domain.Services.Pokemon;

public sealed class PokemonService(HttpClient httpClient) : IPokemonService
{
    public async Task<object?> GetPokemonAsync(string idOrName, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await httpClient.GetFromJsonAsync<object>($"pokemon/{idOrName}", cancellationToken);

            return response;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public Task<List<Models.Pokemon>> GetPokemonListAsync()
    {
        throw new NotImplementedException();
    }
}