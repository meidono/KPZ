using task3.Interfaces;

namespace task3.Shapes;

public class Triangle : Shape
{
    public Triangle(IRenderer renderer) : base(renderer)
    {
    }

    public override string Name => "Triangle";

    public override void Draw()
    {
        _renderer.RenderShape(Name);
    }
} 