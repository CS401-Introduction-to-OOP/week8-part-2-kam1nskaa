namespace week8_2;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        throw new NotImplementedException();
    }
    public override void Close()
    {
        IsOpen = false;
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        Console.WriteLine($"[Diagnostic], Dispose for{Name}");
        Close();
    }
}