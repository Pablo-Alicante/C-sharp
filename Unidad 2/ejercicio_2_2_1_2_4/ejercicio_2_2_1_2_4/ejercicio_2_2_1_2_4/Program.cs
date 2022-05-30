using System;

namespace ejercicio_2_2_1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            int contador = 3;

            Console.WriteLine("El juego consiste en adivinar un número del 1 al 10. Solo tiene 3 oportunidades.");

            while(contador!=0)
            {
                Console.Write("Introduzca un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if(numero!=6)
                {
                    contador = contador - 1;
                    Console.WriteLine("Número incorrecto. Le quedan {0} oportunidades",contador);             
                }

                if (numero==6)
                {
                    Console.WriteLine("Felicidades ha acertado el número.");
                    break;
                }

            }
        }
    }
}
