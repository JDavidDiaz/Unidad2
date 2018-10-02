using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2.DiazUriasJorgeDavid
{
    class Recursividad
    {
        public int Recursivity(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Recursivity(n - 1) + Recursivity(n - 2);
            }
        }
    }
}
