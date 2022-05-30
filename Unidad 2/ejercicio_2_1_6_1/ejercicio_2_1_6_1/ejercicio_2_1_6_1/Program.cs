using System;

namespace ejercicio_2_1_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduzca un número:");
            numero = Convert.ToInt32(
                Console.ReadLine());

            if (0 == numero)
                Console.WriteLine("El número es cero");

            else
                if (0 > numero)
                Console.WriteLine("El número es negativo.");

                else
                    if (0 < numero)
                    Console.WriteLine("El número es positivo");
        }
    }
}
