using System;

namespace ejercicio_3_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;
            float z;
            double resultado;

            Console.WriteLine("El programa resolverá la siguiente ecuación: x^2 + y - z");

            Console.WriteLine();

            Console.Write("Introduzca un valor para x: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduzca un valor para y: ");
            y = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduzca un valor para z: ");
            z = Convert.ToSingle(Console.ReadLine());

            resultado = Math.Pow(x, 2) + y - z;

            Console.WriteLine();

            Console.WriteLine("La ecuación {0}^2+{1}-{2} da como resultado:", x, y, z);
            Console.WriteLine(resultado.ToString("0.00"));
        }
    }
}
