using System;
using System.Diagnostics.CodeAnalysis;

namespace ejercicio_3_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1;
            long n2;

            Console.Write("Introduzca un número: ");
            n1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            n2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
        }
    }
}
