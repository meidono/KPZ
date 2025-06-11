using System;

public class ImageNode : LightNode
{
    public string Href { get; }
    public IImageLoadStrategy Loader { get; }

    public ImageNode(string href, IImageLoadStrategy loader)
    {
        Href = href;
        Loader = loader;
    }

    public void Display()
    {
        Loader.Load(Href);
    }

    public override string InnerHTML => string.Empty;

    public override string OuterHTML => $"<img src=\"{Href}\"/>";
}
