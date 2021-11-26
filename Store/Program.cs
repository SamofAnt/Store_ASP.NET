using Microsoft.AspNetCore.Http.Json;
using Store.Interfaces;
using Store.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICurrentDate, UtcDate>();
builder.Services.AddSingleton<ICatalog, InMemoryCatalog>();
builder.Services.Configure<JsonOptions>(
    options =>
    {
        options.SerializerOptions.WriteIndented = true;
    });

var app = builder.Build();

app.MapGet("/catalog", (ICatalog catalog) => catalog.GetProducts());
app.Run();

//record