// See https://aka.ms/new-console-template for more information
using TeamProject;
using TeamProject.Interfaces;
using TeamProject.Models;
Console.WriteLine("Uperenko Olexander");
IProjectPart myInfoProjectPart = new MyInfoProjectPart();
myInfoProjectPart.Execute();