using System;

namespace ejercicio_2_1_2_1
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

            if (numero1 % 10 == 0)
            {
                Console.WriteLine("{0} es múltiplo de 10",
                    numero1);

                Console.WriteLine("Introduza otro número:");
                numero2 = Convert.ToInt32(
                    Console.ReadLine());

                if (numero2 % 10 == 0)
                    Console.WriteLine("{0} es múltiplo de 10",
                        numero2);
            }


        }
    }
}
