using AraujosPokedex.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationExtensions(builder.Configuration);

var app = builder.Build();

app.MapApplicationExtensions();

app.Run();