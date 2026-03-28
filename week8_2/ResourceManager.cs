using System.Reflection.PortableExecutable;

namespace week8_2;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    public void Add(T resource)
    {
        _resources.Add(resource);
        throw new NotImplementedException();
    }
    public void OpenAll()
    {
        foreach (var r in _resources)
        {
            r.Open();
        }
        throw new NotImplementedException();
    }
    public void CloseAll()
    {
        foreach (var r in _resources)
        {
            r.Close();
        }
        throw new NotImplementedException();
    }
    
}