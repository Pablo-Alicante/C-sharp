using System;

namespace ejercicio_2_1_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduzca un número:");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduzca otro número:");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            if ((numero1 % 2 == 0) && (numero2 % 2 == 0))
                Console.WriteLine("Ambos números son pares");
        }
    }
}
