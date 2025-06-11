class Program
{
    static void Main()
    {
        Console.WriteLine("HTML Rendering with Strategy Pattern");

        var fileImg = new ImageNode("images/logo.png", new FileImageLoader());
        var netImg = new ImageNode("https://fotorelax.ru/wp-content/uploads/2016/02/Beautiful-photos-and-pictures-on-different-topics-01.jpg", new NetworkImageLoader());

        Console.WriteLine(fileImg.OuterHTML);
        fileImg.Display();

        Console.WriteLine(netImg.OuterHTML);
        netImg.Display();
    }
}
