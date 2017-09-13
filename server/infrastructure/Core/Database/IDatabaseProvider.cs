namespace Core
{
  public interface IDatabaseProvider
  {
    string ConnectionString { get; set; }
  }

  public class DatabaseProvider : IDatabaseProvider
  {
    public string ConnectionString { get; set; }
  }
}
