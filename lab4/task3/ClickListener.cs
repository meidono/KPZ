public class ClickListener : IEventListener
{
    public void HandleEvent(string eventType, LightElementNode element)
    {
        Console.WriteLine($"Click event handled for <{element.TagName}> with classes: [{string.Join(", ", element.CssClasses)}]");
    }
}
