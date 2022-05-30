using System;

namespace ejercicio_3_2_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.WriteLine("El programa calculará los primeros 20 valores de la función y = x^2 - 1");

            Console.WriteLine();

            for(x=1;x<=20;x++)
            {
                y = Math.Pow(x, 2) - 1;
                Console.WriteLine("El valor es {0}.",y);
            }
        }
    }
}
