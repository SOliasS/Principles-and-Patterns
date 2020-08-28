using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Singleton_Pattern
{
    public class SingletonMain : IMain
    {
        public void Start()
        {
            var instance=SingeltonBase.GetInstance();
        }
    }
}
