using System;
using System.Linq;

namespace ejercicio_4_1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[3];
            double modulo;

            Console.WriteLine("El programa le pedirá que introduzca valores para 3 variables.\nDespués,mostrará su módulo.");

            Console.WriteLine();

            for(int i=0;i<3;i++)
            {
                Console.Write("Introduzca un valor para la variable: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            modulo = Math.Sqrt((Math.Pow(valores.Sum(), 2)));

            Console.WriteLine();

            Console.WriteLine("Su módulo es {0}.", modulo);
        }
    }
}
