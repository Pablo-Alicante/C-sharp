using System;

namespace ejercicio_3_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double resultado;

            Console.Write("Introduzca un número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            resultado = n1 / n2;

            Console.WriteLine();

            Console.WriteLine("El resultado de dividir {0} entre {1} es:",n1,n2);
            Console.WriteLine(resultado.ToString("0.000"));
        }
    }
}
