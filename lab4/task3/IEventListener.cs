public interface IEventListener
{
    void HandleEvent(string eventType, LightElementNode element);
}
