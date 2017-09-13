using Core;
using Microsoft.EntityFrameworkCore;

namespace Items.Domain.common
{
  public class ItemsContext : DbContext
  {
    public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
    { }

    public DbSet<Item> Items { get; set; }
  }
}
