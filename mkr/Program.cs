using task5.Iterators;

namespace task5;

class Program
{
    static void Main(string[] args)
    {
        var html = new LightElementNode("html");
        var head = new LightElementNode("head");
        var body = new LightElementNode("body");
        
        var title = new LightElementNode("title");
        var titleText = new LightTextNode("My Dream HTML");
        title.AddChild(titleText);
        
        var h1 = new LightElementNode("h1");
        var h1Text = new LightTextNode("Welcome to My Dream HTML!");
        h1.AddChild(h1Text);
        
        var p = new LightElementNode("p");
        var pText = new LightTextNode("This is a paragraph with some text.");
        p.AddChild(pText);
        
        head.AddChild(title);
        body.AddChild(h1);
        body.AddChild(p);
        
        html.AddChild(head);
        html.AddChild(body);

        Console.WriteLine("Original HTML:");
        Console.WriteLine(html.OuterHTML);
        Console.WriteLine("\nIterating in breadth-first order:");
        
        var breadthFirstIterator = new BreadthFirstIterator(html);
        while (breadthFirstIterator.HasNext())
        {
            var node = breadthFirstIterator.Next();
            if (node is LightElementNode element)
            {
                Console.WriteLine($"Тег: <{element.TagName}> (Тип: {(element.IsSelfClosing ? "Одиночний" : "Парний")})");
            }
            else if (node is LightTextNode text)
            {
                Console.WriteLine($"Текст: \"{text.Text}\"");
            }
        }

        Console.WriteLine("\nIterating in depth-first order:");
        var depthFirstIterator = new DepthFirstIterator(html);
        while (depthFirstIterator.HasNext())
        {
            var node = depthFirstIterator.Next();
            if (node is LightElementNode element)
            {
                Console.WriteLine($"Тег: <{element.TagName}> (Тип: {(element.IsSelfClosing ? "Одиночний" : "Парний")})");
            }
            else if (node is LightTextNode text)
            {
                Console.WriteLine($"Текст: \"{text.Text}\"");
            }
        }
    }
} 