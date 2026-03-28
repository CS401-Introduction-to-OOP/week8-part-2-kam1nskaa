namespace week8_2;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
    }
    public override void Close()
    {
        IsOpen = false;
    }
    public void Dispose()
    {
        Console.WriteLine($"[Diagnostic], Dispose for{Name}");
        Close();
    }
}