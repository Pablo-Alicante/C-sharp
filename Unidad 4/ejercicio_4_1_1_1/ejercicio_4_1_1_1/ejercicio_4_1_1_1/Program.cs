using System;

namespace ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] datos = new double[4];
            double mediaAritmetica;

            Console.WriteLine("El programa le pedirá 4 números y calcurá su media aritmética.");

            Console.WriteLine();

            Console.Write("Introduzca el primer número: ");
            datos[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca el segundo número: ");
            datos[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca el tercer número: ");
            datos[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca el cuarto número: ");
            datos[3] = Convert.ToDouble(Console.ReadLine());

            mediaAritmetica = (datos[0] + datos[1] + datos[2] + datos[3]) / 4;

            Console.WriteLine();

            Console.WriteLine("Usted ha introducido los números {0}, {1}, {2} y {3}.", datos[0], datos[1], datos[2], datos[3]);
            Console.Write("La media aritmética de los números introducidos es {0}", mediaAritmetica);

            Console.WriteLine();

        }
    }
}
