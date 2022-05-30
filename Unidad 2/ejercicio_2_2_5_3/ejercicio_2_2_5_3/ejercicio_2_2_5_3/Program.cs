using System;

namespace ejercicio_2_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=10;

            while((numero>=10)&&(numero<=20))
            {
                for (numero = 10; numero <= 20; numero++)
                {
                    if (numero % 5 == 0)
                        Console.WriteLine("{0} es dividible entre 5.",numero);

                    if (numero % 6 == 0)
                        Console.WriteLine("{0} es divisible entre 6.",numero);

                    if (numero % 7 == 0)
                        Console.WriteLine("{0} es divisible entre 7.", numero);
                }

            }
        }
    }
}
