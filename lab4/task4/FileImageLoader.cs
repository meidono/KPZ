public class FileImageLoader : IImageLoadStrategy
{
    public void Load(string href)
    {
        Console.WriteLine($"Loading image from file system: {href}");
    }
}
