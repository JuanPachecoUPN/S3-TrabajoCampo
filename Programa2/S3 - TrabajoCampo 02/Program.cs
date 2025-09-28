using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3___TrabajoCampo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("MENÚ DE FIGURAS GEOMÉTRICAS");
                Console.WriteLine("1. Área del cuadrado");
                Console.WriteLine("2. Área del triángulo");
                Console.WriteLine("3. Área del círculo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine("Área del cuadrado: " + (lado * lado));
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTri = double.Parse(Console.ReadLine());
                    Console.WriteLine("Área del triángulo: " + (baseTri * alturaTri / 2));
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Área del círculo: " + (3.1416 * radio * radio));
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del programa.");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }

            }
        }
    }
}
