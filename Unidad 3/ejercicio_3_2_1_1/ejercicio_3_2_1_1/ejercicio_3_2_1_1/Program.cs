using System;

namespace ejercicio_3_2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            int n2 = 4;
            float divisionEnteros;

            Console.WriteLine("Vamos a dividir 3 entre 4 usando números enteros.");
            divisionEnteros = n1 / n2;
            Console.WriteLine("El resultado de dividir 3 entre 4 es {0}", divisionEnteros);

            Console.WriteLine();

            float m1 = 3;
            float m2 = 4;
            float divisionReales;

            Console.WriteLine("Vamos a dividir 3 entre 4 usando números reales.");
            divisionReales = m1 / m2;
            Console.WriteLine("El resultado de dividir 3 entre 4 es {0}.", divisionReales);
        }
    }
}
