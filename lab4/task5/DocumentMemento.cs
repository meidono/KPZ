public class DocumentMemento
{
    private readonly string _text;

    public DocumentMemento(string text)
    {
        _text = text;
    }

    public string GetSavedText()
    {
        return _text;
    }
}
