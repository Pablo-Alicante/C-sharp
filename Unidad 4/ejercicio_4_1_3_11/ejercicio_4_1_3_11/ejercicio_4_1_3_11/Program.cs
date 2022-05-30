using System;
using System.Linq;

namespace ejercicio_4_1_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int numeroMayor = numeros[0];

            Console.WriteLine("El programa le pedirá que introduzca 4 números enteros. \nDespués, calculará el mayor de ellos.");

            Console.WriteLine();

            for(int i=0;i<4;i++)
            {
                Console.Write("Introduzca un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=1;i<4;i++)
            {
                if(numeros[i]>numeroMayor)
                {
                    numeroMayor = numeros[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("El número mayor de los números introducidos es {0}.", numeroMayor);
        }
    }
}
