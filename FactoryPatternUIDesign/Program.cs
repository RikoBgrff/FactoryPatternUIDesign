using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternUIDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your UI Toolkit:");
            Console.WriteLine("Retro: 'R'");
            Console.WriteLine("Flat: 'F'");
            Console.Write("Choice:"); string choice = Console.ReadLine();
            UIToolKit_AbstractFactory abstractFactory = null;
            if(choice == "R")
            {
                abstractFactory = new RetroUI();
            }
         else   if (choice == "F")
            {
                abstractFactory = new FlatUI();
            }
        Console.WriteLine(abstractFactory.CreateButton().Style);
        }
    }
}
