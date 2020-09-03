using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Adaptor
{
    public class TypeB : ITypeB
    {
        public string OtherRequest()
        {
            return  "I'm Type B";
        }
    }
}
