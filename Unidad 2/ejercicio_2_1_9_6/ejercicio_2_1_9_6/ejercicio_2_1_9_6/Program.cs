using System;

namespace ejercicio_2_1_9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Introduzca un carácter:");
            caracter = Convert.ToChar(
                Console.ReadLine());

            if (caracter >= 0)
                Console.WriteLine("El carácter introducido es una cifra numérica.");

                else
                     if ((caracter == 'a') || (caracter == 'e') || (caracter == 'i') || (caracter == 'o') || (caracter == 'u'))
                     Console.WriteLine("El carácter introducido es una vocal.");

                        else
                        Console.WriteLine("El carácter introducido es una consonante.");
        }
    }
}
