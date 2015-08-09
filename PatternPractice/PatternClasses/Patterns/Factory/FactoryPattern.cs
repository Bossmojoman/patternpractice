using PatternPractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Classes.Patterns.Factory
{
    public  class FactoryPattern : IPattern
    {
        public FactoryPattern()
        {
            //stub
        }

        public void Initialize()
        {
            ///Factory Pattern - 
            string userInput = "";
            do
            {
                userInput = DisplayMenu();

                switch (userInput)
                {
                    case "A":
                    //Run Factory Example
                    case "X":
                        break;
                }

            } while (userInput != "X");
        }

        public string DisplayMenu()
        {
            Console.WriteLine("Run Factory Pattern");
            Console.WriteLine("");
            Console.WriteLine("The Factory Pattern is useful for decoupling an application. This should be used when you have a set of related");
            Console.WriteLine("Classes that need to be instantiated at run time - especially when we do not know which class will be instantiated.");
            Console.WriteLine("For an example of this patter, look at the Menu code for the console Application.  We use a Factory Pattern to Instantiate the different");
            Console.WriteLine("Menu Options, which all inherit from IPattern");
            Console.WriteLine("Press X to return to the main menu");
            var result = Console.ReadLine();
            return result;
        }
    }
}
