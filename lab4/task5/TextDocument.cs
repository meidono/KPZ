public class TextDocument
{
    public string Text { get; private set; } = "";

    public void SetText(string newText)
    {
        Text = newText;
    }

    public DocumentMemento Save()
    {
        return new DocumentMemento(Text);
    }

    public void Restore(DocumentMemento memento)
    {
        Text = memento.GetSavedText();
    }
}
