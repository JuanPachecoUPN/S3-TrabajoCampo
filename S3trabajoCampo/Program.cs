using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3trabajoCampo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Caso: Aplicando condicionales y ciclos en C#

            //Programa 5 – Calificaciones con condicional anidada 
            double promedio, nota1, nota2, nota3;

            Console.Write("Ingrese primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("********************************");

            promedio = Math.Round((nota1 + nota2 + nota3) / 3, 2);
            Console.WriteLine($"Promedio: ({nota1} + {nota2} + {nota3}) / 3 = {promedio}");

            if (promedio >= 17)
            {
                Console.WriteLine("\nTu promedio es EXCELENTE");
            }
            else
            {
                if (promedio >= 13 && promedio <= 16)
                {
                    Console.WriteLine("\nTu promedio es BUENO");
                }
                else
                {
                    if (promedio >= 10 && promedio <= 12)
                    {
                        Console.WriteLine("\nTu promedio es REGULAR");
                    }
                    else
                    {
                        Console.WriteLine("\nTu promedio es DEFICIENTE");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
