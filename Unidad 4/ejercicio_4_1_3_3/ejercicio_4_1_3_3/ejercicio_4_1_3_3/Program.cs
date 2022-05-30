using System;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace ejercicio_4_1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double media;

            Console.WriteLine("El programa le pedirá 10 números.");
            Console.WriteLine("Después calculará su media y mostrará aquellos que estén por encima de la media.");

            Console.WriteLine();

            for(int i=0;i<10;i++)
            {
                Console.Write("Introduzca un número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            media = numeros.Sum() / 10;

            Console.WriteLine();

            for(int j=0;j<10;j++)
            {
                if(numeros[j]>media)
                {
                    Console.WriteLine("El número {0} está por encima de la media.",numeros[j]);
                }
            }
        }
    }
}
