using PatternPractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.PatternClasses.Patterns.NoPattern
{
    public class NoPattern : IPattern

    {
        public string DisplayMenu()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            Console.WriteLine("Invalid Entry, Hit X to Continue");
            string userInput = "";
            do
            {
                userInput = Console.ReadLine();

            } while (userInput != "X");
        }
    }
}
