using Microsoft.EntityFrameworkCore;
using StoreApi.Entities;

namespace StoreApi.Data;

public class SqliteDbContext : DbContext
{
    public string DbPath { get; }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public SqliteDbContext()
    {
        DbPath = "Data/StoreDatabase.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

}
