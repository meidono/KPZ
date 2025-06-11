public class CommandCentre : ICommandCentre
{
    private readonly List<Runway> _runways;

    public CommandCentre(List<Runway> runways)
    {
        _runways = runways;
    }

    public void RequestLanding(Aircraft aircraft)
    {
        Console.WriteLine($"Aircraft {aircraft.Name} requests landing...");

        var freeRunway = _runways.FirstOrDefault(r => r.IsFree);
        if (freeRunway != null)
        {
            Console.WriteLine($"Landing granted to {aircraft.Name} on runway {freeRunway.Id}.");
            freeRunway.OccupiedBy = aircraft;
            freeRunway.HighLightRed();
        }
        else
        {
            Console.WriteLine($"No available runway for {aircraft.Name}.");
        }
    }

    public void RequestTakeOff(Aircraft aircraft)
    {
        var occupiedRunway = _runways.FirstOrDefault(r => r.OccupiedBy == aircraft);
        if (occupiedRunway != null)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {occupiedRunway.Id}...");
            occupiedRunway.OccupiedBy = null;
            occupiedRunway.HighLightGreen();
            Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
        }
        else
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is not assigned to any runway.");
        }
    }
}
