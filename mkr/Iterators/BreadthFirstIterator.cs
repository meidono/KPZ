using System.Collections.Generic;
using task5.Interfaces;

namespace task5.Iterators;

public class BreadthFirstIterator : INodeIterator
{
    private readonly Queue<LightNode> _queue;
    private readonly LightNode _root;

    public BreadthFirstIterator(LightNode root)
    {
        _root = root;
        _queue = new Queue<LightNode>();
        Reset();
    }

    public bool HasNext()
    {
        return _queue.Count > 0;
    }

    public LightNode Next()
    {
        var current = _queue.Dequeue();
        
        if (current is LightElementNode elementNode)
        {
            for (int i = 0; i < elementNode.ChildCount; i++)
            {
                _queue.Enqueue(elementNode.GetChild(i));
            }
        }

        return current;
    }

    public void Reset()
    {
        _queue.Clear();
        _queue.Enqueue(_root);
    }
} 