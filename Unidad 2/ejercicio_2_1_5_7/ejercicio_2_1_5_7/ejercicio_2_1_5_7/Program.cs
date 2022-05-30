using System;

namespace ejercicio_2_1_5_7
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

            if ((numero1 % 2 == 0) && (numero2 % 2 != 0))
                Console.WriteLine("El número {0} es par y el número {1} es impar.",
                    numero1, numero2);

            else
                if ((numero1 % 2 != 0) && (numero2 % 2 == 0))
                Console.WriteLine("El número {0} es impar y el número {1} es par.",
                    numero1, numero2);
        }
    }
}
