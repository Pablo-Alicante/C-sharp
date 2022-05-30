using System;

namespace ejercicio_3_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad;

            Console.Write("Introduzca su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas {0} años.", edad);
        }
    }
}
