using System;

namespace ejercicio_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduzca un número: ");
            numero = Convert.ToInt32(
                Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El número es par.");
        }
    }
}
