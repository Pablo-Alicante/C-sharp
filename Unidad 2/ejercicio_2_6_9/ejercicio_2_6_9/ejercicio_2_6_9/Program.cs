using System;

namespace ejercicio_2_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuadrado;

            Console.Write("Introduzca el tamaño del cuadrado (recuerde que el tamaño solo`puede ser un número del 1 al 9): ");
            cuadrado = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=cuadrado;i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
