using ElectionBoard.Models.Domain;
using ElectionBoard.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureDbContext(builder.Configuration);

  
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();


public static class ServiceCollectionExtentions{

    public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ElectionDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString(ElectionDbContext.ConnectionStringName));
        });
        return services;
    }
}