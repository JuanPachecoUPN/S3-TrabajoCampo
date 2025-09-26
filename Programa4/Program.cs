using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, factorial = 1, suma = 0;
            string dato;

            //Recogidendo variables
            Console.WriteLine("=========================");
            Console.WriteLine("   SUMA DE FACTORIALES   ");
            Console.WriteLine("=========================");
            Console.Write("Ingrese un número: ");
            dato = Console.ReadLine();

            if (int.TryParse(dato, out numero))
            {
                for (int i = 1; i <= numero; i++) {

                    for (int j = 1; j <= i; j++) {
                        factorial = factorial * j;
                    }

                    Console.WriteLine(i+"! = "+ factorial);
                    suma = suma + factorial;

                    factorial = 1; //Vuelve al valor original para operar de nuevo
                }

                //Suma de factoriales
                Console.WriteLine("La suma de factoriales de 1 a {0} es: {1}", numero, suma);

            }
            else
            {
                Console.WriteLine("Error: Se esperaba un número entero. Se finalizará el programa");
            }

            Console.ReadKey();

        }
    }
}
