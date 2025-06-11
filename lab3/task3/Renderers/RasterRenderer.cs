using task3.Interfaces;

namespace task3.Renderers;

public class RasterRenderer : IRenderer
{
    public void RenderShape(string shapeName)
    {
        Console.WriteLine($"Drawing {shapeName} as pixels");
    }
} 