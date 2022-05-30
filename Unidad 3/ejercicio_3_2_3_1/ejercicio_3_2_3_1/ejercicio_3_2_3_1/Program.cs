using System;

namespace ejercicio_3_2_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            double radio;

            Console.WriteLine("El programa calculará el volumen de una esfera.");

            Console.Write("Introduzca el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El volumen de la esfera es {0}.", pi * Math.Pow(radio, 3) * 4 / 3);
        }
    }
}
