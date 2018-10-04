using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2.DiazUriasJorgeDavid
{
    class Program
    {
        static void Main(string[] args)
        {
            //1er Programa
            Console.WriteLine("1.-Programa de algoritmo recursivo para encontrar el minimo de una sucesion\n");
            int Numero;
            Console.WriteLine("Ingresa el limite de numeros para la sucesion");
            Numero = int.Parse(Console.ReadLine());
            int[] Vector1 = new int[Numero];
            for (int i = 0; i < Numero; i++)
            {
                Console.WriteLine("Ingrese el numero {0}", i + 1);
                Vector1[i] = int.Parse(Console.ReadLine());
            }
            Recursividad Sucesion = new Recursividad();
            Console.WriteLine("\nEl Numero minimo de la sucesion es: {0} ", Sucesion.Minimo(Vector1, 0, Vector1[0]));
            Console.ReadKey();
            Console.Clear();

            //2do Programa
            Console.WriteLine("2.-Programa de algoritmo recursivo para encontrar el minimo de una sucesion\n");
            int Numero2;
            Console.WriteLine("Ingresa el limite de numeros para la sucesion");
            Numero2 = int.Parse(Console.ReadLine());
            int[] Vector2 = new int[Numero2];
            for (int j = 0; j < Numero2; j++)
            {
                Console.WriteLine("Ingrese el numero {0}", j + 1);
                Vector2[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEl Numero maximo de la sucesion es: {0} ", Sucesion.Maximo(Vector2, 0, Vector2[0]));
            Console.ReadKey();
            Console.Clear();

            //3er Programa
            Console.WriteLine("3.-Programa de algoritmo recursivo para invertir una sucesion\n");
            int Numero3;
            Console.WriteLine("Ingresa el limite de numeros para la sucesion");
            Numero3 = int.Parse(Console.ReadLine());
            int[] Vector3 = new int[Numero3];
            for (int k = 0; k < Numero3; k++)
            {
                Console.WriteLine("Ingrese el numero {0}", k + 1);
                Vector3[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nLa sucesion Invertida es:\n");
            Sucesion.Invertido(Vector3, 0, Vector3.Length - 1);
            for (int z = 0; z < Vector3.Length; z++)
            {
                Console.WriteLine(Vector3[z]);
            }
            Console.ReadKey();
        }
    }
}
