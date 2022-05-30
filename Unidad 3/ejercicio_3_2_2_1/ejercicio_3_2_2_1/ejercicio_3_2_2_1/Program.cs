using System;

namespace ejercicio_3_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 13;
            int a2 = 6;
            float divisionEnteros;

            Console.WriteLine("Vamos a dividir 13 entre 6 usando números enteros.");
            divisionEnteros = a1 / a2;
            Console.WriteLine("El resultado de dividir 13 entre 6 es {0}.", divisionEnteros);

            Console.WriteLine();

            float b1 = 13;
            float b2 = 6;
            float divisionSP;

            Console.WriteLine("Vamos a dividir 13 entre 6 usando números reales de simple precisión.");
            divisionSP = b1 / b2;
            Console.WriteLine("El resultado de dividir 13 entre 6 es {0}.", divisionSP);

            Console.WriteLine();

            double c1 = 13;
            double c2 = 6;
            double divisionDP;

            Console.WriteLine("Vamos a dividir 13 entre 6 usando números reales de doble precisión.");
            divisionDP = c1 / c2;
            Console.WriteLine("El resultado de dividir 13 entre 6 es {0}.", divisionDP);
        }
    }
}
