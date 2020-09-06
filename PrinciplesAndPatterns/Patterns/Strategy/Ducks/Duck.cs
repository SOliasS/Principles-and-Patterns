using PrinciplesAndPatterns.Patterns.Strategy.Ducks.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Strategy.Ducks
{
    internal class Duck
    {
        /// <summary>
        /// Gets or sets the quack.
        /// </summary>
        /// <value>
        /// The quack.
        /// </value>
        internal IQuackBehavior Quack { get; set; }
        public Duck(IQuackBehavior quack)
        {
            Quack = quack;
        }
    }
}
