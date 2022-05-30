using System;

namespace ejercicio_3_3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra1;
            char letra2;
            char letra3;
            char letra4;

            Console.Write("Introduzca una letra: ");
            letra1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduzca otra letra: ");
            letra2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduzca otra letra: ");
            letra3 = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduzca otra letra: ");
            letra4 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("\"{0}{1}{2}{3}\"", letra4, letra3, letra2, letra1);
        }
    }
}