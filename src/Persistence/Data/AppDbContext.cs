using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<EmployeeEntity> Employees { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeEntity>(entity =>
        {
            entity.ToTable("Employees");
            entity.HasKey(e => e.Id);
        });
    }
}
