using System;

class Program
{
    static void Main()
    {
        var editor = new TextEditor();

        editor.SetText("Перша версiя тексту");
        editor.Save();

        editor.SetText("Друга версiя тексту");
        editor.Save();

        editor.SetText("Третя версiя тексту");
        Console.WriteLine("Поточний текст: " + editor.GetText());

        editor.Undo();
        Console.WriteLine("Пiсля Undo: " + editor.GetText());

        editor.Undo();
        Console.WriteLine("Пiсля другого Undo: " + editor.GetText());

        editor.Undo();
    }
}
