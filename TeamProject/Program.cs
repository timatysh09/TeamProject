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

IProjectPart projectPart = new CurrentDateTimeProjectPart();
projectPart.Execute();

var kovalovPart = new KovalovProjectPart();
kovalovPart.Execute();

IProjectPart bondar = new Bondar();
bondar.Execute();