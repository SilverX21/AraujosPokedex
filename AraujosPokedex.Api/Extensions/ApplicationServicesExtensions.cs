using Scalar.AspNetCore;

namespace AraujosPokedex.Api.Extensions;

public static class ApplicationServicesExtensions
{
    public static IApplicationBuilder MapApplicationExtensions(this WebApplication app)
    {
        app.MapOpenApiSettings();
        app.MapScalarSettings();
        app.UseHttpsRedirection();
        
        return app;
    }
    
    public static IApplicationBuilder MapOpenApiSettings(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }
        
        return app;
    }
    
    public static IApplicationBuilder MapScalarSettings(this WebApplication app)
    {
        app.MapScalarApiReference(options =>
        {
            options.DarkMode = true;
            options.Theme = ScalarTheme.DeepSpace;
        });
        
        return app;
    }
}