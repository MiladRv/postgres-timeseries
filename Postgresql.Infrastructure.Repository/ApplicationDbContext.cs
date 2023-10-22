using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Postgresql.Domain;

namespace Postgresql.Infrastructure.Repository;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
        
    }
    
    public DbSet<Stock> Stocks { get; set; } = default!;
    public DbSet<Company> Companies { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

}