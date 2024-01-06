using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public RepositoryContext(DbContextOptions options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
        .Entity<Product>()
        .HasData(
            new Product() { ProductId = 1, ProductName = "Laptop", Price = 5000 },
            new Product() { ProductId = 2, ProductName = "Mouse", Price = 1000 },
            new Product() { ProductId = 3, ProductName = "Keyboard", Price = 1400 }
        );
    }
}