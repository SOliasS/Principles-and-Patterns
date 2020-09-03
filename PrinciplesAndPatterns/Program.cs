using PrinciplesAndPatterns.Patterns.Adaptor;
using PrinciplesAndPatterns.Singleton_Pattern;
using System;

namespace PrinciplesAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IMain test = new AdaptorMain();
            test = new SingletonMain();
        }
    }
}
