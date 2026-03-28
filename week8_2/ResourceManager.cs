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
   
}