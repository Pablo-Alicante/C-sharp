using System;

namespace ejercicio_2_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Introduzca un carácter:");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case '.':
                case ',':
                case ':':
                case ';':Console.WriteLine("El carácter introducido es un signo de puntuación.");
                    break;

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':Console.WriteLine("El carácter introducido es una cifra numérica.");
                    break;

                default:
                    Console.WriteLine("El carácter introducido es otro tipo de carácter.");
                    break;
            }
        }
    }
}
