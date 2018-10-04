using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2.DiazUriasJorgeDavid
{
    class Recursividad
    {
        public int Minimo(int[] Vector, int Numero, int Min)
        {
            if (Numero != Vector.Length)
            {
                if (Vector[Numero] < Min)
                {
                    Min = Minimo(Vector, Numero + 1, Vector[Numero]);
                }
                else
                {
                    Min = Minimo(Vector, Numero + 1, Min);
                }
            }
            return Min;
        }
        public int Maximo(int[] Vector, int Numero, int Max)
        {
            if (Numero != Vector.Length)
            {
                if (Vector[Numero] > Max)
                {
                    Max = Maximo(Vector, Numero + 1, Vector[Numero]);
                }
                else
                {
                    Max = Maximo(Vector, Numero + 1, Max);
                }
            }
            return Max;
        }
        public void Invertido(int[] Vector, int Inicio, int Final)
        {
            if (Inicio < Final)
            {
                int Reverse = Vector[Inicio];
                Vector[Inicio] = Vector[Final];
                Vector[Final] = Reverse;
                Invertido(Vector, Inicio + 1, Final - 1);
            }
        }
    }
}
