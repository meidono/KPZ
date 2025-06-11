public class LightTextNode : LightNode
{
    public string TextContent { get; }

    public LightTextNode(string text)
    {
        TextContent = text;
    }

    public override string InnerHTML => TextContent;
    public override string OuterHTML => TextContent;
}
