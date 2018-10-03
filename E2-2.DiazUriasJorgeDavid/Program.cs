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
            Stopwatch Cronometro = Stopwatch.StartNew();
            for (int i = 0; i < Numero; i++)
            {
                Console.WriteLine(Sucesion.Iteractivo(i));
            }
            Console.WriteLine("Tiempo en ejecucion: {0}", Cronometro.Elapsed);
            Cronometro.Restart();
            Console.WriteLine("\nSucesion Con metodo de recurisvidad:\n");
            Sucesion.Recursivity(Numero);
            Console.WriteLine("Tiempo en ejecucion: {0}", Cronometro.Elapsed);
            Console.ReadKey();
        }
    }
}