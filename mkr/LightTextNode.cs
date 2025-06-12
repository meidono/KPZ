namespace task5;

public class LightTextNode : LightNode
{
    private readonly string _text;

    public string Text => _text;

    public LightTextNode(string text)
    {
        _text = text;
    }

    public override string OuterHTML => _text;
    public override string InnerHTML => _text;
} 