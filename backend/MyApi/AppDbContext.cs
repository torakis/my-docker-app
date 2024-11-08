using Microsoft.EntityFrameworkCore;

namespace MyApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    // Define a sample DbSet. This could be any table you want to test.
    public DbSet<TestItem> TestItems { get; set; }
}

public class TestItem
{
    public int Id { get; set; }
    public string Name { get; set; }
}