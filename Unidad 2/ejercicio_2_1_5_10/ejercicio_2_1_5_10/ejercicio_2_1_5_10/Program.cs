using System;

namespace ejercicio_2_1_5_10
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

            if (numero1 > numero2)
                Console.WriteLine("El número {0} es mayor que el número {1}.",
                    numero1, numero2);

            else
                if (numero1 < numero2)
                Console.WriteLine("El número {0} es mayor que el número {1}.",
                    numero2, numero1);

                else
                    if (numero1 == numero2)
                    Console.WriteLine("Ambos números son iguales.");
        }
    }
}
