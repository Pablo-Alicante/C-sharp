using System;

namespace ejercicio_3_2_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos de la esfera
            float pi = 3.14f;
            double radio;

            //Datos a calcular
            double superficie;
            double volumen;

            Console.WriteLine("El programa calculará la superficie y el volumen de una esfera.");

            Console.WriteLine();

            Console.Write("Aporte un valor para el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());

            superficie = 4 * pi * Math.Pow(radio, 2);
            volumen = 4 / 3 * pi * Math.Pow(radio, 3);

            Console.WriteLine();

            Console.WriteLine("La superficie de la esfera es:");
            Console.WriteLine(superficie.ToString("0.00000"));
            Console.WriteLine("El volumen de la esfera es:");
            Console.WriteLine(volumen.ToString("0.00000"));
        }
    }
}
