namespace week8_2;

class Program
{
    static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        
        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();

        using (var tempF = new FileResource("temp.log"))
        {
            tempF.Open();
        }
        manager.CloseAll();

        Console.WriteLine("Done.");
    }
}