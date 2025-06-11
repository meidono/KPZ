using task5;

namespace task6;

public class LightHTMLFactory
{
    private static readonly Dictionary<string, LightElementNode> _elements = new();
    private static readonly Dictionary<string, LightTextNode> _textNodes = new();

    public static LightElementNode GetElement(string tagName, bool isBlock = true, bool isSelfClosing = false)
    {
        var key = $"{tagName}_{isBlock}_{isSelfClosing}";
        
        if (!_elements.ContainsKey(key))
        {
            _elements[key] = new LightElementNode(tagName, isBlock, isSelfClosing);
        }
        
        return _elements[key];
    }

    public static LightTextNode GetTextNode(string text)
    {
        if (!_textNodes.ContainsKey(text))
        {
            _textNodes[text] = new LightTextNode(text);
        }
        
        return _textNodes[text];
    }

    public static int GetTotalElementsCount()
    {
        return _elements.Count + _textNodes.Count;
    }
} 