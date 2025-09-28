using System;

public class Class1
{
	public Class1()
	{
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

namespace S3_TrabajoCampo___01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

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

            Console.WriteLine("Resultados");
            Console.WriteLine("El salario de S/. " + salario + " se clasifica como: " + clasificacion);
        }
    }
}

	}
}
