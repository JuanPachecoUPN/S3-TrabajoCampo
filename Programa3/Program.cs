using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese el número de inicio: ");
                int inicio = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de fin: ");
                int fin = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nNúmeros pares entre {inicio} y {fin}:");

                for (int i = inicio; i <= fin; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }

    }
}

