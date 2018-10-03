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
        int NumInicio = 0;
        int Suma;
        int NumSiguiente = 1;
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
                Console.WriteLine(NumInicio);
                return 1;
            }
            else
            {
                Suma = NumInicio;
                NumInicio = NumSiguiente;
                NumSiguiente = Suma + NumSiguiente;
                Console.WriteLine(Suma);
                return Recursivity(n-1);            
            }
        }
    }
}
