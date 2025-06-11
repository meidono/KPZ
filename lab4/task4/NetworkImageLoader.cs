public class NetworkImageLoader : IImageLoadStrategy
{
    public void Load(string href)
    {
        Console.WriteLine($"Loading image from network: {href}");
    }
}
