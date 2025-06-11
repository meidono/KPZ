using task3.Interfaces;

namespace task3.Shapes;

public abstract class Shape
{
    protected readonly IRenderer _renderer;

    protected Shape(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public abstract string Name { get; }
    public abstract void Draw();
} 