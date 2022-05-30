using System;

namespace ejercicio_2_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;

            Console.WriteLine("Introduza un número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 != 0)
            {
                Console.WriteLine("Introduzca otro número:");
                numero2 = Convert.ToInt32(Console.ReadLine());

                resultado = numero1 * numero2;

                Console.WriteLine("El resultado de multiplicar {0} * {1} es {2}",numero1, numero2, resultado);
            }

                else
                    if (numero1 == 0)
                    Console.WriteLine("El producto de 0 por cualquier número es 0");
        }
    }
}
