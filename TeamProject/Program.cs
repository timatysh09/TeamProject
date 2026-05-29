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

IProjectPart projectPart = new CurrentDateTimeProjectPart();
projectPart.Execute();


Console.WriteLine($"--------------------------------------");
IProjectPart projectPart1 = new Tyshchyk();
projectPart1.Execute();
Console.WriteLine($"--------------------------------------");
LosClass losProjectPart = new LosClass();
losProjectPart.Execute();
Console.WriteLine($"--------------------------------------");
IProjectPart kalinichenkoPart = new Kalinichenko();
kalinichenkoPart.Execute();
Console.WriteLine($"--------------------------------------");
kachur kachur = new kachur();
kachur.Execute();
Console.WriteLine($"--------------------------------------");
IProjectPart bondar = new Bondar();
bondar.Execute();
Console.WriteLine($"--------------------------------------");
IProjectPart myInfoProjectPart = new MyInfoProjectPart();
myInfoProjectPart.Execute();