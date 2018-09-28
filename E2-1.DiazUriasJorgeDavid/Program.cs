using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Factorial
{
    class Program
    {
        //Por Metodo de Recursividad
        int numero;
        public Program(int n)
        {
            numero = n;
        }
        public int Factorial (int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            return numero * Factorial(numero - 1);
        }
        //Factorial con FOR
        static void Main(string[] args)
        {            
            Stopwatch stopwatch = Stopwatch.StartNew();
            int Numero, Factorial;
            Console.WriteLine("Ingresa un numero");
            Numero = int.Parse(Console.ReadLine());
            Factorial = Numero;
            if ( Numero == 0)
            {
                Factorial = 1;
            }
            for (int i = Numero - 1; i >= 1; i--)
            {
                if (i > (Numero - 6))
                {
                    Factorial = Factorial * i;
                }
            }
            Console.WriteLine("\nEl Factorial de 6 numeros del numero {0} es: {1}\nTiempo transcurrido : {2}", Numero, Factorial, stopwatch.Elapsed);

            //Utilizando Recursividad
            Console.WriteLine("\n\nPor metodo de recursividad");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            Console.WriteLine("\nIngrese un numero");
            int numero = int.Parse(Console.ReadLine());
            Program Recursividad = new Program (numero);
            Console.WriteLine("El numero factorial de: {0} es : {1}\nCon un tiempo de ejecucion de: {2}", numero, Recursividad.Factorial(numero), stopwatch2.Elapsed);
            Console.ReadKey();
        }
    }
}
