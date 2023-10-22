using Microsoft.EntityFrameworkCore;
using Postgresql.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine($"connectionstring: {builder.Configuration.GetConnectionString("Npgsql")}");

builder.Services
    .AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Npgsql")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();