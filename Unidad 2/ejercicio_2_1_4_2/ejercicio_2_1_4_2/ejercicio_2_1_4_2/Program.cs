using System;

namespace ejercicio_2_1_4_2
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

            Console.WriteLine("Introduzca otro número:");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            resultado = numero1 / numero2;

            if (numero2 != 0)
            {
                Console.WriteLine("El resultado de la operación {0} : {1} es {2}",
                     numero1, numero2, resultado);
            }

            else
                 if (numero2 == 0)
                Console.WriteLine("Error: No se puede dividir entre cero");
        }
    }
}
