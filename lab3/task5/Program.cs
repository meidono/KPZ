namespace task5;

class Program
{
    static void Main(string[] args)
    {
        var div = new LightElementNode("div");
        div.AddClass("container");

        var h1 = new LightElementNode("h1");
        h1.AddChild(new LightTextNode("Привіт, світ!"));
        div.AddChild(h1);

        var p = new LightElementNode("p");
        p.AddClass("text");
        p.AddChild(new LightTextNode("Це приклад використання LightHTML."));
        div.AddChild(p);

        var img = new LightElementNode("img", isBlock: false, isSelfClosing: true);
        img.AddClass("image");
        div.AddChild(img);

        Console.WriteLine("OuterHTML:");
        Console.WriteLine(div.OuterHTML);
        
        Console.WriteLine("\nInnerHTML:");
        Console.WriteLine(div.InnerHTML);
        
        Console.WriteLine($"\nКількість дочірніх елементів: {div.ChildCount}");
    }
} 