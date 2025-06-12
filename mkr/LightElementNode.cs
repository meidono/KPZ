namespace task5;

public class LightElementNode : LightNode
{
    private readonly string _tagName;
    private readonly bool _isBlock;
    private readonly bool _isSelfClosing;
    private readonly List<string> _cssClasses;
    private readonly List<LightNode> _children;

    public LightElementNode(string tagName, bool isBlock = true, bool isSelfClosing = false)
    {
        _tagName = tagName;
        _isBlock = isBlock;
        _isSelfClosing = isSelfClosing;
        _cssClasses = new List<string>();
        _children = new List<LightNode>();
        OnCreated();
    }

    public void AddChild(LightNode child)
    {
        _children.Add(child);
        child.OnInserted();
    }

    public LightNode GetChild(int index)
    {
        return _children[index];
    }

    public void AddClass(string cssClass)
    {
        _cssClasses.Add(cssClass);
        OnClassListApplied();
    }

    public override string OuterHTML
    {
        get
        {
            var classes = _cssClasses.Count > 0 ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
            OnStylesApplied();
            
            if (_isSelfClosing)
            {
                return $"<{_tagName}{classes}/>";
            }

            var result = $"<{_tagName}{classes}>{InnerHTML}</{_tagName}>";
            OnTextRendered();
            return result;
        }
    }

    public override string InnerHTML
    {
        get
        {
            if (_isSelfClosing)
            {
                return string.Empty;
            }

            var separator = _isBlock ? "\n" : "";
            return string.Join(separator, _children.Select(child => child.OuterHTML));
        }
    }

    public int ChildCount => _children.Count;

    public override void OnRemoved()
    {
        foreach (var child in _children)
        {
            child.OnRemoved();
        }
        base.OnRemoved();
    }
} 