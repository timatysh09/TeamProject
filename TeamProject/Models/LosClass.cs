using TeamProject.Interfaces;

namespace TeamProject.Models;

public class LosClass : IProjectPart
{
    public void Execute()
    {
        Console.WriteLine("LOS (Line Of Sight) - Active");
    }
}
