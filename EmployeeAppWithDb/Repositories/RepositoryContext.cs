using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public RepositoryContext(DbContextOptions options)
    : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
        .Entity<Employee>()
        .HasData(
            new Employee() { Id = 1, FirtName = "Ebubekir", LastName = "Karakurt", CompanyName = "EkaCompany" },
            new Employee() { Id = 2, FirtName = "Ali", LastName = "Doğmuş", CompanyName = "EkaCompany" },
            new Employee() { Id = 3, FirtName = "Mehmet", LastName = "Dağ", CompanyName = "EkaCompany" }
        );
    }
}