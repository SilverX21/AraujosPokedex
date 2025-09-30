using AraujosPokedex.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AraujosPokedex.Database.Configurations;

internal class PokemonConfigurations : IEntityTypeConfiguration<Pokemon>
{
    public void Configure(EntityTypeBuilder<Pokemon> builder)
    {
        builder.ToTable("Pokemons", schema: "dbo");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(t => t.Nickname)
            .HasMaxLength(30)
            .HasDefaultValue(null);

        builder.Property(t => t.Region)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(t => t.IsOwned)
            .HasDefaultValue(false);

        builder.Property(t => t.DateCaught)
            .HasDefaultValue(null);
    }
}