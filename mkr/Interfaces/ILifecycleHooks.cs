namespace task5.Interfaces;

public interface ILifecycleHooks
{
    void OnCreated();
    void OnInserted();
    void OnRemoved();
    void OnStylesApplied();
    void OnClassListApplied();
    void OnTextRendered();
} 