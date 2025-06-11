using task3.Interfaces;

namespace task3.Shapes;

public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer)
    {
    }

    public override string Name => "Square";

    public override void Draw()
    {
        _renderer.RenderShape(Name);
    }
} 