using Microsoft.EntityFrameworkCore;

namespace Core.Database
{
  public class DataBaseContext : DbContext
  {
    // public DbSet<MyModel> MyModels { get; set; }

    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    { }
  }
}
