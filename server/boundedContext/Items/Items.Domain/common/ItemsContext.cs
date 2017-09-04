using Microsoft.EntityFrameworkCore;

namespace Items.Domain.common
{
  public class ItemsContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // optionsBuilder.UseSqlServer();
      base.OnConfiguring(optionsBuilder);
    }
  }
}
