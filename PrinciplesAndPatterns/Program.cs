using PrinciplesAndPatterns.Patterns.Adaptor;
using PrinciplesAndPatterns.Patterns.Strategy;
using PrinciplesAndPatterns.Singleton_Pattern;
using System;

namespace PrinciplesAndPatterns
{
   public class Program
    {
        static void Main(string[] args)
        {
            execute(new AdaptorMain());
            execute(new StrategyMain());
            execute(new SingletonMain());


            //executes the Pattern
            void execute(IMain pattern)
            {
                pattern.Start();
            }
        }
    }
}
