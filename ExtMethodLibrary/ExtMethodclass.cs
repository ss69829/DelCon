using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMethodLibrary
{
    public static class ExtMethodclass
    {
        public static int Add(this int x, int y, int z)
        {
            return x + y + z;
        }

            public static int Multiply(this int s, int a)
            {
                return s * a;
            }
        
    }
}

