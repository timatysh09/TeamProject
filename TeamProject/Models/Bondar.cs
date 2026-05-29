using TeamProject.Interfaces;

namespace TeamProject.Models;

public class Bondar : IProjectPart
{
    public void Execute()
    {
        Console.WriteLine("Artem Bondar");
        Console.WriteLine($"Current date and time: {DateTime.Now:G}");
    }
}
