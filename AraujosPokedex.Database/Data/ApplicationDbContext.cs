using System.Reflection;
using AraujosPokedex.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AraujosPokedex.Database.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Pokemon> Pokemons { get; set; }
}