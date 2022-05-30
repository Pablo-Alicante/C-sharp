using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ejercicio_4_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            double[] numeros;
            double media;

            Console.WriteLine("El programa le pedirá que introduzca una determinada cantidad de números, usted elegirá el límite.");
            Console.WriteLine("Después, calculará y mostrará la media de esos números.");

            Console.WriteLine();

            Console.Write("¿Cuántos números desea introducir?: ");
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            numeros = new double[cantidadNumeros];

            for(int i=0;i<cantidadNumeros;i++)
            {
                Console.Write("Introduzca un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine();

            media = numeros.Sum() / cantidadNumeros;
            Console.WriteLine("La media de todos los números introducidos es {0}.", media);
        }
    }
}
