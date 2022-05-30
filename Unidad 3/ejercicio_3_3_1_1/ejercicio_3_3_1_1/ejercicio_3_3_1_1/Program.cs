using System;

namespace ejercicio_3_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.Write("Introduzca un letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':Console.WriteLine("Ha introducido una vocal.");
                    break;
                default:Console.WriteLine("Ha introducido una consonante.");
                    break;
            }
        }
    }
}
