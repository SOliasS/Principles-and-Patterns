using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Adaptor
{
    public class Adaptor:ITypeA
    {
        public Adaptor(TypeB typeB)
        {
            TypeB = typeB;
        }

        public TypeB TypeB { get; }

        public string request()
        {
            return TypeB.OtherRequest();
        }
    }
}
