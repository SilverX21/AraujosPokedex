using System.ComponentModel.DataAnnotations;

namespace AraujosPokedex.Domain.Models.Base;

public sealed class AraujosPokedexOptions
{
    [Required]
    public ConnectionStrings ConnectionStrings { get; set; }

    [Required]
    public PokeApiSettings PokeApiSettings { get; set; }
}

public sealed class ConnectionStrings
{
    [Required]
    public string PostgreSqlConnection { get; set; }
}

public sealed class PokeApiSettings
{
    [Required]
    public string BaseUrl { get; set; }
}