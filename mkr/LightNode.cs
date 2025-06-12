using task5.Interfaces;

namespace task5;

public abstract class LightNode : ILightNode, ILifecycleHooks
{
    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }

    public virtual void OnCreated() { }
    public virtual void OnInserted() { }
    public virtual void OnRemoved() { }
    public virtual void OnStylesApplied() { }
    public virtual void OnClassListApplied() { }
    public virtual void OnTextRendered() { }
} 