using System;

namespace ejercicio_2_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuadrado = 1;

            Console.Write("Introduzca un número para mostrar su cuadrado: ");
            cuadrado = Convert.ToInt32(Console.ReadLine());

            while(cuadrado!=0)
            {
                Console.WriteLine("El cuadrado de {0} es {1}", cuadrado, cuadrado * cuadrado);

                Console.Write("Introduzca un número para mostrar su cuadrado: ");
                cuadrado = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
