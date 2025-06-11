using task5;

namespace task6;

public class TextToHTMLConverter
{
    private readonly LightHTMLFactory _factory;
    private bool _isFirstLine = true;

    public TextToHTMLConverter()
    {
        _factory = new LightHTMLFactory();
    }

    public LightElementNode ConvertToHTML(string[] lines)
    {
        var root = LightHTMLFactory.GetElement("div");
        root.AddClass("book-content");

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var element = GetElementForLine(line);
            var textNode = LightHTMLFactory.GetTextNode(line.Trim());
            element.AddChild(textNode);
            root.AddChild(element);
        }

        return root;
    }

    private LightElementNode GetElementForLine(string line)
    {
        if (_isFirstLine)
        {
            _isFirstLine = false;
            return LightHTMLFactory.GetElement("h1");
        }

        if (line.Length < 20)
        {
            return LightHTMLFactory.GetElement("h2");
        }

        if (char.IsWhiteSpace(line[0]))
        {
            return LightHTMLFactory.GetElement("blockquote");
        }

        return LightHTMLFactory.GetElement("p");
    }
} 