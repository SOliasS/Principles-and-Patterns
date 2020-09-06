using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Strategy.Ducks.Quack
{
    internal class QuackBehaviorSimple : IQuackBehavior
    {
        /// <summary>
        /// Quackings this instance.
        /// Prints Quack
        /// </summary>
        public void Quacking()
        {
            Console.WriteLine("Quack");
        }
    }
}
