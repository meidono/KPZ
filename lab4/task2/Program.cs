class Program
{
    static void Main()
    {
        var runway1 = new Runway();
        var runway2 = new Runway();
        var runways = new List<Runway> { runway1, runway2 };

        var commandCentre = new CommandCentre(runways);

        var aircraft1 = new Aircraft("Cessna 172", commandCentre);
        var aircraft2 = new Aircraft("Piper PA-28", commandCentre);
        var aircraft3 = new Aircraft("Cirrus SR22", commandCentre);

        aircraft1.Land();
        aircraft2.Land();
        aircraft3.Land(); 
        aircraft1.TakeOff(); 
        aircraft3.Land();    
    }
}
