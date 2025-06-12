using System.Collections.Generic;
using task5.Interfaces;

namespace task5.Iterators;

public class DepthFirstIterator : INodeIterator
{
    private readonly Stack<LightNode> _stack;
    private readonly LightNode _root;

    public DepthFirstIterator(LightNode root)
    {
        _root = root;
        _stack = new Stack<LightNode>();
        Reset();
    }

    public bool HasNext()
    {
        return _stack.Count > 0;
    }

    public LightNode Next()
    {
        var current = _stack.Pop();
        
        if (current is LightElementNode elementNode)
        {
            for (int i = elementNode.ChildCount - 1; i >= 0; i--)
            {
                _stack.Push(elementNode.GetChild(i));
            }
        }

        return current;
    }

    public void Reset()
    {
        _stack.Clear();
        _stack.Push(_root);
    }
} 