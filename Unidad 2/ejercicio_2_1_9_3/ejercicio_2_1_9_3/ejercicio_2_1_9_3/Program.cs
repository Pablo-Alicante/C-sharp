using System;

namespace ejercicio_2_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Introduzca un carácter:");
            letra = Convert.ToChar(Console.ReadLine());

            switch(letra)
            { 
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':Console.WriteLine("El carácter introducido es una vocal.");
                    break;

                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'ñ':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':Console.WriteLine("El carácter introducido es una consonante.");
                    break;

                default:Console.WriteLine("El carácter introducido es una cifra numérica.");
                    break;
            }
        }
    }
}
