using System;

namespace ejercicio_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool edo = false;
            int numero = 35;
            int n = 0;

            Console.WriteLine("El juego consiste en adivinar un número entre 1 y 100. Solo tiene 6 oportunidades.");

            for (int contador=5;contador>=0; contador--)
            {
                Console.Write("Introduzca un número: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > numero)
                    Console.WriteLine("Número incorrecto, le quedan {0} oportunidades.", contador);

                else
                    if (n < numero)
                    Console.WriteLine("Número incorrecto, le quedan {0} oportunidades.", contador);

                else
                {
                    edo = true;
                    break;
                }
            }
            if (edo)
                Console.WriteLine("Felicidades, ha acertado el número.");
        }
    }
}
