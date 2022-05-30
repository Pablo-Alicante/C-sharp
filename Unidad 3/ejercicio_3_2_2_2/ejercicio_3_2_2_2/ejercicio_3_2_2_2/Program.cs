using System;

namespace ejercicio_3_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            float pi = 3.14f;

            Console.WriteLine("El programa calculará el área de un círculo.");

            Console.Write("Introduzca el radio: ");
            radio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El área del círculo es {0}.", pi * Math.Pow(radio,2));
        }
    }
}
