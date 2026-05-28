using TeamProject.Interfaces;

namespace TeamProject.Models;

public class CurrentDateTimeProjectPart : IProjectPart
{
    public void Execute()
    {
        Console.WriteLine($"Current date and time: {DateTime.Now:G}");
    }
}
