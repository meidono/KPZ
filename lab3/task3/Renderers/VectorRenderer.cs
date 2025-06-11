using task3.Interfaces;

namespace task3.Renderers;

public class VectorRenderer : IRenderer
{
    public void RenderShape(string shapeName)
    {
        Console.WriteLine($"Drawing {shapeName} as vector");
    }
} 