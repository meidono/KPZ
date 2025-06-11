using task3.Interfaces;

namespace task3.Shapes;

public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer)
    {
    }

    public override string Name => "Circle";

    public override void Draw()
    {
        _renderer.RenderShape(Name);
    }
} 