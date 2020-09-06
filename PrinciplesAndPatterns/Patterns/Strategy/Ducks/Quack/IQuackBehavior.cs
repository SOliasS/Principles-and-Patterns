using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Strategy.Ducks.Quack
{
    internal interface IQuackBehavior
    {
        /// <summary>
        /// Quackings this instance.
        /// </summary>
        void Quacking();
    }
}
