
using Core.DI;

namespace Items.Services
{
  public interface IItemService : IDependency
  {
    string[] GetItems();
  }

  public class ItemService : IItemService
  {
    public string[] GetItems()
    {
      return new[] { "item1", "item2", "item3" };
    }
  }
}
