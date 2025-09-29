namespace AraujosPokedex.Domain.Contracts;

public record AddPokemonRequest(string Name, string NickName, DateTime DateCaught);