using TeamProject.Interfaces;
using TeamProject.Models;

Console.WriteLine("Tymofii Tyschyk");
Console.WriteLine("Pavlo Los");
Console.WriteLine("Artem Bondar");
Console.WriteLine("Vasyl Kovalov"); // Teacher
Console.WriteLine("Uperenko Olexander");
Console.WriteLine("Tkach Oleksii");
Console.WriteLine("Kalinichenko Vlad");
Console.WriteLine("Tkach Oleksii");
Console.WriteLine("Somyk Yurii");
Console.WriteLine("Ilya Kachur");

var parts = new List<IProjectPart>
{
    new CurrentDateTimeProjectPart(),
    new MyInfoProjectPart(),
    new Tyshchyk(),
    new LosClass(),
    new Bondar(),
    new Kalinichenko(),
    new kachur(),
};


foreach (var part in parts)
{
    part.Execute();
}