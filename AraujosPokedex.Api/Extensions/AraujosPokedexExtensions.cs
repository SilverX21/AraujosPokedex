using AraujosPokedex.Domain.Models.Base;

namespace AraujosPokedex.Api.Extensions;

public static class AraujosPokedexExtensions
{
    public static IServiceCollection AddApplicationExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationOptions(configuration);
        services.AddApiSettings();
        
        return services;
    }
    
    public static IServiceCollection AddApplicationOptions(this IServiceCollection services, IConfiguration configuration)
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
}