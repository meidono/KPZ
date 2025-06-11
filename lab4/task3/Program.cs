class Program
{
    static void Main()
    {
        var div = new LightElementNode("div", DisplayType.Block, TagCloseType.Paired);
        div.AddClass("container");

        var p = new LightElementNode("p", DisplayType.Block, TagCloseType.Paired);
        p.AddClass("clickable");
        p.AddChild(new LightTextNode("Click me!"));

        var clickListener = new ClickListener();
        p.AddEventListener("click", clickListener);

        div.AddChild(p);

        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\nSimulating click on <p>...");
        p.TriggerEvent("click");

        Console.WriteLine("\nSimulating mouseover on <p> (no listener attached)...");
        p.TriggerEvent("mouseover");
    }
}
