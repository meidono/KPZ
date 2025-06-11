using System.Text;

public enum DisplayType { Block, Inline }
public enum TagCloseType { Paired, SelfClosing }

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public DisplayType DisplayType { get; }
    public TagCloseType CloseType { get; }
    public List<string> CssClasses { get; } = new();
    public List<LightNode> Children { get; } = new();

    private Dictionary<string, List<IEventListener>> eventListeners = new();

    public LightElementNode(string tagName, DisplayType displayType, TagCloseType closeType)
    {
        TagName = tagName;
        DisplayType = displayType;
        CloseType = closeType;
    }

    public void AddChild(LightNode node) => Children.Add(node);

    public void AddClass(string className) => CssClasses.Add(className);

    public void AddEventListener(string eventType, IEventListener listener)
    {
        if (!eventListeners.ContainsKey(eventType))
        {
            eventListeners[eventType] = new List<IEventListener>();
        }
        eventListeners[eventType].Add(listener);
    }

    public void TriggerEvent(string eventType)
    {
        Console.WriteLine($" Event '{eventType}' triggered on <{TagName}>");
        if (eventListeners.TryGetValue(eventType, out var listeners))
        {
            foreach (var listener in listeners)
            {
                listener.HandleEvent(eventType, this);
            }
        }
    }

    public override string InnerHTML =>
        string.Join("", Children.Select(child => child.OuterHTML));

    public override string OuterHTML
    {
        get
        {
            var sb = new StringBuilder();
            var classAttr = CssClasses.Any() ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (CloseType == TagCloseType.SelfClosing)
            {
                sb.Append($"<{TagName}{classAttr}/>");
            }
            else
            {
                sb.Append($"<{TagName}{classAttr}>");
                sb.Append(InnerHTML);
                sb.Append($"</{TagName}>");
            }

            return sb.ToString();
        }
    }
}
