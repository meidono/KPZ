using System.Collections.Generic;

public class TextEditor
{
    private TextDocument _document = new TextDocument();
    private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

    public void SetText(string newText)
    {
        _document.SetText(newText);
    }

    public string GetText()
    {
        return _document.Text;
    }

    public void Save()
    {
        _history.Push(_document.Save());
    }

    public void Undo()
    {
        if (_history.Count > 0)
        {
            var memento = _history.Pop();
            _document.Restore(memento);
        }
        else
        {
            System.Console.WriteLine("Немає збережених станiв для вiдкату.");
        }
    }
}
