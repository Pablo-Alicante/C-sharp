using System;

namespace ejercicio_2_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto;
            int ancho;

            Console.Write("Introduzca el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            for (int i1 = 1; i1 <= alto; i1++)
            {
                for (int i2 = 1; i2 < ancho; i2++)
                {
                    Console.Write('*');
                }
                Console.WriteLine('*');
            }
        }
    }
}
