using System;

namespace ejercicio_2_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1=-1;
            int numero2=-1;

            while ((numero1 != 0) || (numero2 != 0))
            {
                Console.Write("Introduzca un número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca otro número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero1 % numero2 == 0)
                    Console.WriteLine("{0} es múltiplo de {1}",
                        numero1, numero2);

                else
                    Console.WriteLine("{0} no es múltiplo de {1}",
                        numero1,numero2);
            }
        }
    }
}
