using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Singleton_Pattern
{
    public class SingletonMain : IMain
    {
        public void Start()
        {
            //var test=SingeltonBase(); Cannot be used since the Constructor is private
            var instance=SingeltonBase.GetInstance();
        }
    }
}
