using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesAndPatterns.Singleton_Pattern
{
    /// <summary>
    /// only one Object of the Class can ever exist
    /// only the Get Instance Method can initalice the Class
    /// </summary>
    public class SingeltonBase
    {
        private static SingeltonBase Instance;
        public static SingeltonBase GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingeltonBase();
            }
            return Instance;
        }
        private SingeltonBase()
        {

        }
    }
}
