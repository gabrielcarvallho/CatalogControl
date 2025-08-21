using CatalogControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogControl.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}