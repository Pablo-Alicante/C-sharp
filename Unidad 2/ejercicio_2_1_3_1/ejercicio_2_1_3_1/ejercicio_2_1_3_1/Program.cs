using System;

namespace ejercicio_2_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;

            Console.WriteLine("Introduzca un número:");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            if (numero1 != 0)
            {
                Console.WriteLine("Introduzca otro número:");
                numero2 = Convert.ToInt32(
                    Console.ReadLine());

                resultado = numero1 * numero2;

                Console.WriteLine("{0} * {1} da como resultado {2}",
                    numero1, numero2, resultado);

            }

            if (numero1 == 0)
                Console.WriteLine("El producto de 0 por cualquier número es 0");
        }
    }
}
