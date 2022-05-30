using System;

namespace ejercicio_2_1_9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Introduzca un carácter:");
            caracter = Convert.ToChar(
                Console.ReadLine());

            if ((caracter >= '0') && (caracter <= '9'))
                Console.WriteLine("El carácter introducido es una cifra numérica");

                else
                    if ((caracter == '.') || (caracter == ',') || (caracter == ':') || (caracter == ';'))
                    Console.WriteLine("El carácter introducido es un signo de puntuación");

                        else
                        Console.WriteLine("El carácter introducido es otro tipo de carácter");

                      
        }
    }
}
