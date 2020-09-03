using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Patterns.Adaptor
{
    public class AdaptorMain : IMain
    {
        //Enable one Object of a kind to to be used as an object of another kind
        //Does not change Behavior or alters
        public void Start()
        {
            ITypeA target = new Adaptor(new TypeB());
            target.request();
        }
    }
}
