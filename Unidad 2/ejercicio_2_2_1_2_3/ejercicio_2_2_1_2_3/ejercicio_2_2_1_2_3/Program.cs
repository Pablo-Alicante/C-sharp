using System;

namespace ejercicio_2_2_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cifras = 0;

            Console.Write("Introduzca un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while(numero>0)
            {
                numero = numero / 10;

                cifras = cifras + 1;
            }

            Console.WriteLine("El número tiene {0} cifras.",cifras);
        }
    }
}
