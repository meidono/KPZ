using task4;

class Program
{
    static void Main()
    {
        Virus covid19 = new Virus("SARS-CoV-2", "Coronavirus", 0.015, 3);
        Virus omicron = new Virus("B.1.1.529", "Coronavirus", 0.012, 2);
        Virus delta = new Virus("B.1.617.2", "Coronavirus", 0.010, 2);
        Virus alpha = new Virus("B.1.1.7", "Coronavirus", 0.008, 1);

        omicron.AddChild(alpha);
        covid19.AddChild(omicron);
        covid19.AddChild(delta);

        Console.WriteLine("\nOriginal Family:");
        covid19.Display();

        Virus clonedFamily = (Virus)covid19.Clone();

        Console.WriteLine("\nCloned Family:");
        clonedFamily.Display();
    }
}