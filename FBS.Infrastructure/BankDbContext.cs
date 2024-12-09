using FBS.Infrastructure.Configs;
using FBS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FBS.Infrastructure;

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options)
        :base(options)
    {
    }
    
    public DbSet<CustomerEntity> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerConfigs());
        base.OnModelCreating(modelBuilder);
    }
}