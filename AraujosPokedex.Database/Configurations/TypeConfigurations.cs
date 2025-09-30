using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AraujosPokedex.Database.Configurations;

internal class TypeConfigurations : IEntityTypeConfiguration<Domain.Models.Type>
{
    public void Configure(EntityTypeBuilder<Domain.Models.Type> builder)
    {
        builder.ToTable("Types", schema: "dbo");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasData(new List<Domain.Models.Type>
        {
            new Domain.Models.Type { Id = 1, Name = "Normal"},
            new Domain.Models.Type { Id = 2, Name = "Fire"},
            new Domain.Models.Type { Id = 3, Name = "Water"},
            new Domain.Models.Type { Id = 4, Name = "Grass"},
            new Domain.Models.Type { Id = 5, Name = "Electric"},
            new Domain.Models.Type { Id = 6, Name = "Psychic"},
            new Domain.Models.Type { Id = 7, Name = "Ice"},
            new Domain.Models.Type { Id = 8, Name = "Dragon"},
            new Domain.Models.Type { Id = 9, Name = "Dark"},
            new Domain.Models.Type { Id = 10, Name = "Fairy"},
            new Domain.Models.Type { Id = 11, Name = "Fighting"},
            new Domain.Models.Type { Id = 12, Name = "Flying"},
            new Domain.Models.Type { Id = 13, Name = "Poison"},
            new Domain.Models.Type { Id = 14, Name = "Ground"},
            new Domain.Models.Type { Id = 15, Name = "Rock"},
            new Domain.Models.Type { Id = 16, Name = "Bug"},
            new Domain.Models.Type { Id = 17, Name = "Ghost"},
            new Domain.Models.Type { Id = 18, Name = "Steel"}
        });
    }
}