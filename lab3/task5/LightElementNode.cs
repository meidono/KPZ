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
    }

    public void AddChild(LightNode child)
    {
        _children.Add(child);
    }

    public void AddClass(string cssClass)
    {
        _cssClasses.Add(cssClass);
    }

    public override string OuterHTML
    {
        get
        {
            var classes = _cssClasses.Count > 0 ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
            
            if (_isSelfClosing)
            {
                return $"<{_tagName}{classes}/>";
            }

            return $"<{_tagName}{classes}>{InnerHTML}</{_tagName}>";
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
} 