using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2.DiazUriasJorgeDavid
{
    class Fibonacci
    {
        public int Iteractivo(int n)
        {
            int NumInicio = 0;
            int NumSiguiente = 1;
            for (int i = 0; i < n; i++)
            {
                int Suma = NumInicio;
                NumInicio = NumSiguiente;
                NumSiguiente = Suma + NumSiguiente;
            }
            return NumInicio;
        }
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
