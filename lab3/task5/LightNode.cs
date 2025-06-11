using task5.Interfaces;

namespace task5;

public abstract class LightNode : ILightNode
{
    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }
} 