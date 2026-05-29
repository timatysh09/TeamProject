using TeamProject.Interfaces;

namespace TeamProject.Models;

public class MyInfoProjectPart : IProjectPart
{
    public void Execute()
    {
        Console.WriteLine("Name: Uperenko Olexsandr");
        Console.WriteLine("16 y.o. dev");
        Console.WriteLine("Current OS: " + System.Runtime.InteropServices.RuntimeInformation.OSDescription);
    }
}
