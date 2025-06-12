using task5;

namespace task5.Interfaces;

public interface INodeIterator
{
    bool HasNext();
    LightNode Next();
    void Reset();
} 