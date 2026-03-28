using System.Collections.Generic;
namespace week8_2;
public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        return _items.Count();
    }
}