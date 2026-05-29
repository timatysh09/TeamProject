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

IProjectPart losProjectPart = new LosClass();
losProjectPart.Execute();

kachur kachur = new kachur();
kachur.Execute();

IProjectPart bondar = new Bondar();
bondar.Execute();

IProjectPart kalinichenkoPart = new Kalinichenko();
kalinichenkoPart.Execute();