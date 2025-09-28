using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese el salario mensual en soles (S/): ");
                string entrada = Console.ReadLine();

                // Intentamos convertir la entrada a un número decimal
                if (decimal.TryParse(entrada, out decimal salario))
                {
                    string clasificacion;

                    if (salario < 1200)
                    {
                        clasificacion = "Bajo";
                    }
                    else if (salario <= 2500)
                    {
                        clasificacion = "Medio";
                    }
                    else
                    {
                        clasificacion = "Alto";
                    }

                    Console.WriteLine($"Clasificación del salario: {clasificacion}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");

                }
            }
        }
    }
}


