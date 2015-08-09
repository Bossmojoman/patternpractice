using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternPractice.Classes.Patterns.Factory;
using PatternPractice.Classes;

namespace PatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Factory Pattern - hey look, Factory pattern is a perfect fit for our menu, go figure.
            string userInput = "";
            do
            {
                userInput = DisplayMenu();
                if (userInput == "X")
                    break;

                var selectedPattern = MenuFactory.Get(userInput);
                selectedPattern.Initialize();
              

            } while (userInput != "X");

         

        }

        static string DisplayMenu()
        {

            Console.WriteLine("Select Pattern");
            Console.WriteLine();
            Console.WriteLine("A. Factory");
            Console.WriteLine("B. Abstract Factory");
            Console.WriteLine("C. Visitor");
            Console.WriteLine("X. Exit");
            var result = Console.ReadLine();
            return result;

        }
    }
}
