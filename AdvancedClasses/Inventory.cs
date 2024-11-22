namespace AdvancedClasses;
public class Inventory
{
    private readonly List<IItem> _items = new List<IItem>();

    public void Add(IItem item) => _items.Add(item);

    public void Remove(IItem item) => _items.Remove(item);

    public void DisplayItems() => _items.ForEach(i => Console.WriteLine(i.GetDescription()));

    public void UseItems() => _items.ForEach(i => i.Use());
}
