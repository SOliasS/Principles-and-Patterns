using PrinciplesAndPatterns.Patterns.Strategy.Ducks;
using PrinciplesAndPatterns.Patterns.Strategy.Ducks.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Strategy
{
    public class StrategyMain : IMain
    {
        /// <summary>
        /// Instead of individual Classes with Depenency explosions
        /// this Pattern allows to Algorithm at runtime 
        /// </summary>
        public void Start()
        {
            //Create Rubber Duck (can't quack)
            var rubberDuck = new Duck(new QuackBehaviorNo());
            rubberDuck.Quack.Quacking();
            //Create Rubber Duck 
            var wildDuck = new Duck(new QuackBehaviorSimple());
            wildDuck.Quack.Quacking();
        }
    }
}
