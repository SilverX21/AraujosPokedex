using AraujosPokedex.Database.Data;
using AraujosPokedex.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AraujosPokedex.Api.Extensions;

public static class AraujosPokedexExtensions
{
    public static IServiceCollection AddApplicationExtensions(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddApplicationOptions(configuration);
        services.AddApiSettings();

        return services;
    }

    public static IServiceCollection AddApplicationOptions(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddOptions<AraujosPokedexOptions>()
            .Bind(configuration)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }

    public static IServiceCollection AddApiSettings(this IServiceCollection services)
    {
        services.AddOpenApi();
        services.AddEndpointsApiExplorer();

        return services;
    }

    public static IServiceCollection AddCustomDatabase(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            var appOptions = sp.GetRequiredService<IOptions<AraujosPokedexOptions>>().Value;

            options.UseNpgsql(appOptions.ConnectionStrings.PostgreSqlConnection);
        });

        return services;
    }
}