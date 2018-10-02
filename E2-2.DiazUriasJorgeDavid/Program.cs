using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2.DiazUriasJorgeDavid
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Ingrese la cantidad maxima de numeros a sumar de la sucesion de fibonacci");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSucesion Con ciclo FOR:\n");
            Fibonacci Sucesion = new Fibonacci();
            Stopwatch Cronometro1 = Stopwatch.StartNew();
            for (int i = 0; i < Numero; i++)
            {
                Console.WriteLine(Sucesion.Iteractivo(i));
            }
            Console.WriteLine("Tiempo en ejecucion: {0}", Cronometro1.Elapsed);
            Console.WriteLine("\nSucesion Con Metodo de Recursividad:\n");
            Stopwatch Cronometro2 = Stopwatch.StartNew();
            for (int j = 0; j < Numero; j++)
            {
                Console.WriteLine(Sucesion.Recursivity(j));
            }
            Console.WriteLine("Tiempo en ejecucion: {0}", Cronometro2.Elapsed);
            Console.ReadKey();
        }
    }
}