using task3.Renderers;
using task3.Shapes;

public class Program
{
    public static void Main()
    {
        var vectorRenderer = new VectorRenderer();
        var rasterRenderer = new RasterRenderer();

        var circle = new Circle(vectorRenderer);
        var square = new Square(rasterRenderer);
        var triangle = new Triangle(vectorRenderer);

        Console.WriteLine("Drawing shapes with different renderers:");
        Console.WriteLine();

        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine("\nChanging renderer for circle:");
        circle = new Circle(rasterRenderer);
        circle.Draw();
    }
} 