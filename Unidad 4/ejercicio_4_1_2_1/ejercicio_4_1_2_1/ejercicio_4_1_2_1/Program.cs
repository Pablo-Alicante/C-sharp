using System;

namespace ejercicio_4_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
            int mesIntroducido;

            Console.WriteLine("El programa le pedirá que le indique un mes (1 = enero, 12 = diciembre).");
            Console.WriteLine("Después mostrará en pantalla el número de días que tiene ese mes.");

            Console.WriteLine();

            Console.Write("Introduzca un mes: ");
            mesIntroducido = Convert.ToInt32(Console.ReadLine());

            mesIntroducido--; //Decrementamos en una unidad para acceder a la posición correcta.

            Console.WriteLine();

            Console.WriteLine("El mes {0} tiene {1} días.", mesIntroducido + 1, dias[mesIntroducido]);



        }
    }
}
