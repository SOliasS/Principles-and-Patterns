using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Strategy.Ducks.Quack
{
    internal class QuackBehaviorNo : IQuackBehavior
    {
        /// <summary>
        /// Quackings this instance.
        /// No Quacking
        /// </summary>
        public void Quacking()
        {
            //Do nothing
        }
    }
}
