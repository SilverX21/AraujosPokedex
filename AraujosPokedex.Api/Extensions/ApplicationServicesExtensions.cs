using AraujosPokedex.Api.Endpoints.Pokemon;
using Scalar.AspNetCore;

namespace AraujosPokedex.Api.Extensions;

public static class ApplicationServicesExtensions
{
    public static WebApplication MapApplicationExtensions(this WebApplication app)
    {
        app.MapOpenApiSettings();
        app.MapScalarSettings();
        app.UseHttpsRedirection();
        app.MapPokemonEndpoints();

        return app;
    }

    public static WebApplication MapOpenApiSettings(this WebApplication app)
    {
        if (app.Environment.IsDevelopment()) app.MapOpenApi();

        return app;
    }

    public static WebApplication MapScalarSettings(this WebApplication app)
    {
        app.MapScalarApiReference(options =>
        {
            options.DarkMode = true;
            options.Theme = ScalarTheme.DeepSpace;
        });

        return app;
    }
}