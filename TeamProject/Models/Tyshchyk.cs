using System;
using System.Collections.Generic;
using System.Text;
using TeamProject.Interfaces;

namespace TeamProject.Models
{
    public class Tyshchyk : IProjectPart
    {
        public void Execute()
        {
            Console.WriteLine($"My name is Tymofii and i`m 16 years old.");
        }
    }
}
/*
В командному проєкті

взяти за основу гілку kovalov

в директорія Models додати клас який реалізує TeamProject/Interfaces/IProjectPart.cs інтерфейс
 
ваш клас повинен виводити в консоль повідомслення про вас, та що небудь ще.
 
додати в Programs.cs виклик свого класу
 */