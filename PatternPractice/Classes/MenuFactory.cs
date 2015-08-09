using PatternPractice.Classes.Patterns.Factory;
using PatternPractice.Interfaces;
using PatternPractice.PatternClasses.Patterns.AbstractFactory;
using PatternPractice.PatternClasses.Patterns.NoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Classes
{
    public static class MenuFactory
    {

        public static IPattern Get(string menuOption)
        {
            switch (menuOption)
            {
                case "A":
                    //Run Factory Example
                    return new FactoryPattern();
                case "B":
                    //Run Factory Example
                    return new AbstractFactory();

                default:
                    return new NoPattern();
            }
        }
    }
}
