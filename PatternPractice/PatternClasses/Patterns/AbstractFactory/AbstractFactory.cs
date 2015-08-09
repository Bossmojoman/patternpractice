using PatternPractice.Interfaces;
using PatternPractice.PatternClasses.Patterns.AbstractFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.PatternClasses.Patterns.AbstractFactory
{
    public class AbstractFactory : IPattern
    {
        public string DisplayMenu()
        {
            Console.WriteLine("Run Abstract Factory Pattern");
            Console.WriteLine("");
            Console.WriteLine("like the Factory Pattern, The Abstract Factory Pattern is useful for decoupling an application.");
            Console.WriteLine("This should be used when you have a set of related");
            Console.WriteLine("families of Classes that need to be instantiated at run time ");
            Console.WriteLine("It is easier to think of this pattern as a factory of factory patterns. ");
            Console.WriteLine("It Provides an interface for creating families of related or dependent objects without specifying their concrete classes. ");
            Console.WriteLine("");
            Console.WriteLine("Press 1 to execute pattern");
            Console.WriteLine("Press X to return to the main menu");
            var result = Console.ReadLine();
            return result;
        }

        public void Initialize()
        {
       
            string userInput = "";
            do
            {
                userInput = DisplayMenu();

                switch (userInput)
                {
                    case "1":
                        //Run Factory Example
                        var undeadDungeonFactory = new UndeadDungeonFactory();
                        var undeadDungeonMaster = new DungeonMaster(undeadDungeonFactory);
                        undeadDungeonMaster.RunAttacks();

                        var goblinDungeonFactory = new GoblinDungeonFactory();
                        var goblinDungeonMaster = new DungeonMaster(goblinDungeonFactory);
                        goblinDungeonMaster.RunAttacks();

                        break;
                    case "X":
                        break;
                }

            } while (userInput != "X");
        }
    }
}
